using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Cipher
{
    public static class StreamCipher
    {
        public static class OneTimePad
        {
            public static StreamCipherDTO Encrypt(byte[] fileByteData)
            {
                //Generated Crypto Key Bytes
                var cryptoKey = GenerateByteCryptoKey(fileByteData.Length);

                //Generated Crypto Text
                byte[] cryptoText;

                if (Properties.Settings.Default.isMultiThreadingEnabled)
                    cryptoText = MultiThreadingXor(fileByteData, cryptoKey).Result;
                else
                    cryptoText = GetXor(fileByteData, cryptoKey);

                //Saving and returning a dto
                return new StreamCipherDTO(cryptoText, cryptoKey);
            }

            public static string Decrypt(byte[] cryptoText, byte[] cryptoKey) => Encoding.UTF8.GetString(GetXor(cryptoText, cryptoKey));

            public static byte[] GetBytes(string bitString)
            {
                return Enumerable.Range(0, bitString.Length / 8).
                    Select(pos => Convert.ToByte(
                        bitString.Substring(pos * 8, 8),
                        2)
                    ).ToArray();
            }
            public static BitArray GenerateCryptoKey(int size)
            {
                Random rnd = new Random();

                byte[] cryptoKeyBytes = new byte[size];
                rnd.NextBytes(cryptoKeyBytes);

                return new BitArray(cryptoKeyBytes);
            }
            public static byte[] GenerateByteCryptoKey(int size)
            {
                Random rnd = new Random();

                byte[] cryptoKeyBytes = new byte[size];
                rnd.NextBytes(cryptoKeyBytes);

                return cryptoKeyBytes;
            }
            public static byte[] GetXor(byte[] firstArray, byte[] secondArray)
            {
                var length = firstArray.Length;

                byte[] result = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = (byte)(firstArray[i] ^ secondArray[i]);
                }
                return result;
            }

            public async static Task<byte[]> MultiThreadingXor(byte[] firstArray, byte[] secondArray)
            {
                int numberOfAvailableThreads = Process.GetCurrentProcess().Threads.Count;

                #region SeperatingChunks

                List<byte[]> firstArrayChunks = new List<byte[]>();
                List<byte[]> secondArrayChunks = new List<byte[]>();

                int min = 0;
                int range = firstArray.Length / numberOfAvailableThreads;

                for(int i = 0; i < numberOfAvailableThreads; i++)
                {
                    var temp = firstArray.Skip(min).Take(range).ToArray();
                    firstArrayChunks.Add(temp);

                    var temp2 = secondArray.Skip(min).Take(range).ToArray();
                    secondArrayChunks.Add(temp);

                    min += range;
                }

                int remainder = firstArray.Length % numberOfAvailableThreads;
                for(int i = 0; i < remainder; i++)
                {
                    firstArrayChunks[i] = addByteToArray(firstArrayChunks[i], firstArray[firstArray.Length - remainder + i]);
                    secondArrayChunks[i] = addByteToArray(secondArrayChunks[i], secondArray[secondArray.Length - remainder + i]);
                }
                #endregion

                #region ParallelThreadingXor

                //Fix the multi threading Tasks..

                List<Task<byte[]>> tasks = new List<Task<byte[]>>();

                for(int i = 0; i < numberOfAvailableThreads - 1; i++)
                {
                    tasks.Add(Task.Run(() => GetXor(firstArrayChunks[i], secondArrayChunks[i])));
                }

                var results = await Task.WhenAll(tasks);

                byte[] response = new byte[firstArray.Length];

                foreach(var byteArray in results)
                {
                    System.Buffer.BlockCopy(byteArray, 0, response, response.Length, byteArray.Length);
                }

                #endregion

                return response;
            }

            public static byte[] addByteToArray(byte[] bArray, byte newByte)
            {
                byte[] newArray = new byte[bArray.Length + 1];

                bArray.CopyTo(newArray, 1);

                newArray[0] = newByte;

                return newArray;
            }
        }
    }
}

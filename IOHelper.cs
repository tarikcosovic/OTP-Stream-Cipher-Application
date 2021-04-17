
using System.IO;

namespace Stream_Cipher
{
    public static class IOHelper
    {
        public static class TextIO
        {
            public static string ReadText(string pathFile)
            {
                string result = "";

                using (StreamReader sr = new StreamReader(pathFile))
                {
                    result = sr.ReadToEnd();
                }
                
                return result;
            }

            public static bool WriteText(string pathFile, string message)
            {
                bool result = false;

                using (StreamWriter sw = new StreamWriter(new MemoryStream()))
                {
                    try
                    {
                        sw.Write(message);
                        sw.Flush();

                        using (var file = File.OpenWrite(pathFile))
                        {
                            sw.BaseStream.Position = 0;
                            sw.BaseStream.CopyTo(file);
                        }

                        result = true;
                    }
                    catch (IOException)
                    {

                    }
                }

                return result;
            }
        }
    }
}

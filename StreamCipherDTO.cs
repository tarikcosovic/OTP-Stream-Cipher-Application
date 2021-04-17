using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_Cipher
{
    public class StreamCipherDTO
    {
        public byte[] cryptoText { get; set; }

        public byte[] cryptoKey { get; set; }

        public StreamCipherDTO(byte[] _cryptoText = null, byte[] _cryptoKey = null)
        {
            this.cryptoText = _cryptoText;
            this.cryptoKey = _cryptoKey;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Decorator
{
    public class EncryptedCloudStream : Stream
    {
        private readonly Stream stream;

        public EncryptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }
        public void Write(string stream)
        {
            var encrypted = Encrypt(stream);
            this.stream.Write(encrypted);
        }

        private string Encrypt(string plaintext)
        {
            return "@$%^&*((($%";
        }
    }
}

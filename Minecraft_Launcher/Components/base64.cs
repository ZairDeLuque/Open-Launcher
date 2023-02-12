using System.Text;

namespace ZairDeLuqueContent.Base64EncoderAndDecoder
{
    internal class base64
    {

        public static string Encoder(string input)
        {
            var TextBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(TextBytes);
        }

        public static string Decoder(string input_2)
        {
            var EncoderBytes = Convert.FromBase64String(input_2);
            return Encoding.UTF8.GetString(EncoderBytes);
        }
    }
}

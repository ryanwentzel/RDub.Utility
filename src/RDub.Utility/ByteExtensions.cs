using System.Text;

namespace RDub.Utility
{
    /// <summary>
    /// Extension methods that operate on bytes.
    /// </summary>
    public static class ByteExtensions
    {
        private const string HexFormatString = "x2";

        /// <summary>
        /// Converts a byte array to its hexadecimal string representation.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string ToHexString(this byte[] buffer)
        {
            var builder = new StringBuilder();
            foreach (var item in buffer)
            {
                builder.Append(item.ToString(HexFormatString));
            }

            return builder.ToString();
        }
    }
}
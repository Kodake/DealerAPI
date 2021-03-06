using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace BackEnd.Helpers
{
    public static class FormFileExtensions
    {
        public static async Task<byte[]> GetBytesFromFile(this IFormFile formFile)
        {
            await using var memoryStream = new MemoryStream();
            await formFile.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}

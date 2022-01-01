using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication4.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}

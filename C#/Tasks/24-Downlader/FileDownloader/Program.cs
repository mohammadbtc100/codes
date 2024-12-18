using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
namespace FileDownloader
{
        class Program
        {
            private static readonly HttpClient client = new HttpClient();

            static async Task Main(string[] args)
            {
                string url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTjffTuQoiK2H_mdaKkrC31EcmwEPGzWt8Hiw&s"; // Replace with your file URL
                string outputPath = "downloaded_file.jpg"; // Specify the output file path

                try
                {
                    await DownloadFileAsync(url, outputPath);
                    Console.WriteLine("File downloaded successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error downloading file: {ex.Message}");
                }
            }

            private static async Task DownloadFileAsync(string url, string outputPath)
            {
                using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode(); // Throw if not a success code.

                    using (var stream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await stream.CopyToAsync(fileStream); // Copy the content to the file stream
                    }
                }
            }
        }
}



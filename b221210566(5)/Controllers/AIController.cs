using b221210566_5_.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace b221210566_5_.Controllers
{
    [Authorize(Roles = "Admin, Employee")]

    public class AIController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const string DeepAIEndpoint = "https://api.deepai.org/api/image-similarity"; // Veya uygun DeepAI model endpoint'i
        private const string DeepAIApiKey = "d580cf0c-2202-4a57-95ee-7ff02b3e5b77"; // DeepAI API anahtarınızı buraya ekleyin.

        public AIController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AnalyzePhoto(IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                ViewBag.ErrorMessage = "Lütfen bir fotoğraf yükleyin.";  // Burada mesajı netleştiriyoruz
                return View("Index"); // Hata mesajı ile ana sayfaya dön
            }

            var filePath = Path.GetTempFileName();

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                // AI API'sine istekte bulun ve sonuçları al
                var aiResults = await GetAIRecommendations(filePath);

                if (aiResults == null || !aiResults.Any())
                {
                    ViewBag.ErrorMessage = "AI sonuçları alınamadı. Lütfen tekrar deneyin.";
                    ViewBag.AIResults = null;
                }
                else
                {
                    // İlk 5 sonucu alın
                    ViewBag.AIResults = aiResults.Take(5).ToList();
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Bir hata oluştu: " + ex.Message;
                ViewBag.AIResults = null;
            }
            finally
            {
                // Geçici dosyayı sil
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }

            return View("Index"); // Sonuçlarla ana sayfaya dön
        }


        private async Task<List<string>> GetAIRecommendations(string filePath)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Multipart form verisi oluştur
                    var formData = new MultipartFormDataContent();
                    formData.Add(new ByteArrayContent(System.IO.File.ReadAllBytes(filePath)), "image", "photo.jpg");

                    // DeepAI API anahtarı
                    client.DefaultRequestHeaders.Add("Api-Key", "D580CF0C-2202-4A57-95EE-7FF02B3E5B77");

                    // API'ye POST isteği gönder
                    var response = await client.PostAsync("https://api.deepai.org/api/image-similarity", formData);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                        var outputUrls = responseData?.output_urls as IEnumerable<string>;
                        return outputUrls?.ToList() ?? new List<string>();
                    }
                }
            }
            catch
            {
                // Hata durumunda boş liste döndür
                return null;
            }

            return null;
        }

        private List<string> ParseAIResults(string resultJson)
        {
            // DeepAI JSON yanıtını ayrıştır
            dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(resultJson);
            var recommendations = new List<string>();

            if (jsonResponse != null && jsonResponse.output != null)
            {
                foreach (var output in jsonResponse.output)
                {
                    recommendations.Add(output.ToString());
                }
            }

            return recommendations;
        }

    }
}


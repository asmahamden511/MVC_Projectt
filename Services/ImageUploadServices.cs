namespace MVC_Projec2.Services
{

    public interface IImageUploadService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
        void DeleteImage(string imageUrl);
    }

    public class ImageUploadServices: IImageUploadService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public ImageUploadServices(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        public async Task<string> UploadImageAsync(IFormFile imageFile)
        { 
         
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads", "halls");
            Directory.CreateDirectory(uploadsFolder);

         
            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

    
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            
            return $"/uploads/halls/{uniqueFileName}";
        }


        public void DeleteImage(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl)) return;

            var filePath = Path.Combine(_environment.WebRootPath, imageUrl.TrimStart('/'));
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }

    }
}

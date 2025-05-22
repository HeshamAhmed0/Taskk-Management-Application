namespace Taskk_Management_Application.PL.Helping
{
    public class DocumentSetting
    {
        public static string Upload(IFormFile file,string FolderName)
        {
            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Files",FolderName);
            var FileName = $"{Guid.NewGuid()}{file.FileName}";
            var FilePath = Path.Combine(FolderPath,FileName);
            using var FileStream=new FileStream(FilePath, FileMode.Create);
            file.CopyTo(FileStream);
            return FileName;
        }

        public static void Delete(string fileName,string FolderName)
        {
            var FilePath = Path.Combine(Directory.GetCurrentDirectory(),
                                       @"WWWroot\Files",
                                       FolderName,
                                       fileName
                                       );
            if(File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
    }
}


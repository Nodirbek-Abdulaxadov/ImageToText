using IronOcr;

namespace ImageToText.Lib
{
    public static class ITT
    {
        public static string Convert(string path)
        {
            var Ocr = new IronTesseract();
            using (var Input = new OcrInput())
            {
                Input.AddImage(path);
                var Result = Ocr.Read(Input);
                return Result.Text;
            }
        }
    }
}
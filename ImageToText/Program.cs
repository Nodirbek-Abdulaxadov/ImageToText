using IronOcr;

string path = @"C:\Users\Nodirbek\Desktop\salom.png";
var Ocr = new IronTesseract();
using (var Input = new OcrInput())
{
    Input.AddImage(path);
    var Result = Ocr.Read(Input);
    Console.WriteLine(Result.Text);
}
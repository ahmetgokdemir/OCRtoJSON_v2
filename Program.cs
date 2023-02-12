// See https://aka.ms/new-console-template for more information

using Aspose.OCR;

string path = @"C:\Users\hp\OneDrive\Masaüstü\OCRtoJSON_v2\sample.png";
// @"C:\Users\hp\OneDrive\Masaüstü\OCRtoJSON_v2\sample.png"
// Get file name.


//if (File.Exists(path))
//{
//    Console.WriteLine("File exists :)");
//}
//else
//{
//    Console.WriteLine("Oh, File does not exist");

//}

// Initialize an instance of AsposeOcr class
AsposeOcr api = new AsposeOcr();

// Recognize the input image
RecognitionResult result = api.RecognizeImage(path, new RecognitionSettings());
List<string> result_json = new List<string>();  
 
// push json data to list
for (int i = 0; i < result.RecognitionLinesResult.Count; i++)
{
    result_json.Add(result.RecognitionLinesResult[i].TextInLine);
}

foreach (var item in result_json)
{
    // Print result as JSON
    Console.WriteLine($"JSON DATA: {item}");
}




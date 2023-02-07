

using DepremOcrBot;
using RestSharp;
using System.Text.Json;

var model = new Model();
model.data = new List<string>();
model.data.Add("Bahçelievler Mahallesi Atatürk bulvarı no 334 daire 4  Adıyaman");
DepremOcrBot.DepremOcrService.Upload_Text(model);


Console.WriteLine("Hello, World!");


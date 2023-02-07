


using RestSharp;
using System.Net;
using System.Text;
using System.Text.Json;

namespace DepremOcrBot
{
  internal class DepremOcrService
  {
    public static object JsonConvert { get; private set; }

    public static void Upload_Text(Model m)
    {


      var client = new RestClient("https://mertcobanov-deprem-ocr-2.hf.space/run/upload-text");
      RestRequest request = new RestRequest("POST");
      var json = JsonSerializer.Serialize(m);
      request.AddBody(json, "application/json");

      var result = client.Execute(request);
      var statusCode = result.StatusCode;
      var mes = result.ErrorMessage;

    }
  }
}

using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

var http = new HttpClient();
http.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var json = @"{
  ""product"": {
    ""title"": ""Gaming Mouse"",
    ""description"": ""High precision gaming mouse""
  },
  ""availability"": {
    ""shipToLocationAvailability"": {
      ""quantity"": 10
    }
  }
}";

var content = new StringContent(json, Encoding.UTF8, "application/json");

var response = await http.PostAsync(
    "https://api.ebay.com/sell/inventory/v1/inventory_item/GM-001",
    content
);
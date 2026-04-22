using System.Net.Http;
using System.Net.Http.Headers;

var http = new HttpClient();
http.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", accessToken);

var response = await http.GetAsync(
    "https://api.ebay.com/buy/browse/v1/item_summary/search?q=laptop"
);

var content = await response.Content.ReadAsStringAsync();
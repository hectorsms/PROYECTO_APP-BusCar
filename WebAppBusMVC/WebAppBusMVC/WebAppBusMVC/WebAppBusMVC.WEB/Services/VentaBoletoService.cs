using Newtonsoft.Json;
using System.Text;
using WebAppBusMVC.WEB.Models;

namespace WebAppBusMVC.WEB.Services
{
    public class VentaBoletoService
    {

        public static async Task<IEnumerable<DestinoViewModel>> GetDestinos()
        {
            var url = "http://localhost:5276/api/Destino" ;
            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(url);

            var apiResponse = await response.Content.ReadAsStringAsync();
            var destinoResponse = JsonConvert.DeserializeObject<IEnumerable<DestinoViewModel>>(apiResponse);

            return destinoResponse;

        }

        public static async Task<IEnumerable<OrigenViewModel>> GetOrigenes()
        {
            var url = "http://localhost:5276/api/Origen";
            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(url);

            var apiResponse = await response.Content.ReadAsStringAsync();
            var origenResponse = JsonConvert.DeserializeObject<IEnumerable<OrigenViewModel>>(apiResponse);

            return origenResponse;

        }
    }
}

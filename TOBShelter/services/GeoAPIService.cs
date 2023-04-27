using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json;
using System;
using System.Drawing.Text;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TOBShelter.Types.Base;

namespace TOBShelter.services
{
    internal static class GeoAPIService
    {
        private static readonly HttpClient CLIENT = new HttpClient();

        private class ApiGouvResponseSchema
        {
            internal string Type { get; set; }
            internal Feature[] Features { get; set; }

            internal class Feature
            {
                internal string Type { get; set; }
                internal Properties Properties { get; set; }
                internal Geometry Geometry { get; set; }
            }

            internal class Properties
            {
                internal string Nom { get; set; }
                internal string Code { get; set; }
                internal int Score { get; set; }
            }

            internal class Geometry
            {
                internal string Type { get; set; }
                internal double[] Coordinates { get; set; }
            }
        }

        internal static async Task<Coordinates> GetCommuneCoordinates(string postalCode, string communeName)
        {
            if (String.IsNullOrEmpty(postalCode))
                throw new ArgumentNullException(nameof(postalCode));
            if (String.IsNullOrEmpty(communeName))
                throw new ArgumentNullException(nameof(communeName));

            var urlBuilder = new UriBuilder("https://geo.api.gouv.fr/communes");

            var query = new StringBuilder();

            // Parameters
            query.Append($"codePostal={Uri.EscapeDataString(postalCode)}&");
            query.Append($"nom={Uri.EscapeDataString(communeName)}&");

            // fields
            query.Append($"fields=code&");

            // format
            query.Append($"format=geojson&");

            // geometry
            query.Append($"geometry=centre");

            urlBuilder.Query = query.ToString();

            var response = await CLIENT.GetAsync(urlBuilder.ToString());
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception)
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();

            dynamic obj = JsonConvert.DeserializeObject(content);

            if (obj.features.Count == 0)
                return null;

            double tmp1 = obj.features[0].geometry.coordinates[0];
            double tmp2 = obj.features[0].geometry.coordinates[1];

            return new Coordinates(tmp1, tmp2);
        }
    }
}
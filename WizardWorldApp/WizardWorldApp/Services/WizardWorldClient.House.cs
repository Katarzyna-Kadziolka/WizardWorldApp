using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WizardWorldApp.Data.Houses;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task<List<House>> GetHousesAsync() {
            var response = await _client.GetAsync("Houses");
            return await response.Content.DeserializeAsync<List<House>>();
        }

        public async Task<House> GetHousesByIdAsync(Guid id) {
            var response = await _client.GetAsync($"Houses/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }
            return await response.Content.DeserializeAsync<House>();
        }
    }
}
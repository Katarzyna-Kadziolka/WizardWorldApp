using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WizardWorldApp.Data.MagicalCreatures;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task<List<MagicalCreature>> GetMagicalCreaturesAsync() {
            var response = await _client.GetAsync("MagicalCreatures");
            return await response.Content.DeserializeAsync<List<MagicalCreature>>();
        }

        public async Task<MagicalCreature> GetMagicalCreatureByIdAsync(Guid id) {
            var response = await _client.GetAsync($"MagicalCreatures/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }
            return await response.Content.DeserializeAsync<MagicalCreature>();
        }
    }
}
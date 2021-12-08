using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WizardWorldApp.Data.Spells;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task<List<Spell>> GetSpellsAsync(string firstName = null, SpellType? type = null,
            string incantation = null) {
            var query = new Dictionary<string, string>();
            if (firstName is not null) query.Add("Name", firstName);
            if (type is not null) query.Add("SpellType", type.ToString());
            if (incantation is not null) query.Add("Incantation", incantation);
            var response = await _client.GetAsync("Spell", query);
            return await response.Content.DeserializeAsync<List<Spell>>();
        }

        public async Task<Spell> GetSpellByIdAsync(Guid id) {
            var response = await _client.GetAsync($"spell/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }
            return await response.Content.DeserializeAsync<Spell>();
        }
    }
}
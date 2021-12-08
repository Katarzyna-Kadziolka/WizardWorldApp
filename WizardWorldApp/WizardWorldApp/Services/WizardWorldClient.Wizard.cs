using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WizardWorldApp.Data.Wizards;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task<List<Wizard>> GetWizardsAsync(string name = null, string lastName = null) {
            var query = new Dictionary<string, string>();
            if (name is not null) query.Add("FirsName", name);
            if (lastName is not null) query.Add("LastName", lastName.ToString());
            var response = await _client.GetAsync("Wizards", query);
            return await response.Content.DeserializeAsync<List<Wizard>>();
        }

        public async Task<Wizard> GetWizardByIdAsync(Guid id) {
            var response = await _client.GetAsync($"Wizards/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }
            return await response.Content.DeserializeAsync<Wizard>();
        }
    }
}
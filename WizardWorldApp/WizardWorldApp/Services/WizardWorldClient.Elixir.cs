using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WizardWorldApp.Data.Elixirs;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task<List<Elixir>> GetElixirsAsync(ElixirQuery elixirQuery = null) {
            var query = new Dictionary<string, string>();
            if (elixirQuery is not null) {
                if (elixirQuery.Name is not null) query.Add("Name", elixirQuery.Name);
                if (elixirQuery.Difficulty is not null) query.Add("Difficulty", elixirQuery.Difficulty.ToString());
                if (elixirQuery.Manufacturer is not null) query.Add("Manufacturer", elixirQuery.Manufacturer);
                if (elixirQuery.Ingredient is not null) query.Add("Ingredient", elixirQuery.Ingredient);
                if (elixirQuery.InventorFullName is not null)
                    query.Add("InventorFullName ", elixirQuery.InventorFullName);
            }

            var response = await _client.GetAsync("Elixirs", query);
            return await response.Content.DeserializeAsync<List<Elixir>>();
        }

        public async Task<Elixir> GetElixirsByIdAsync(Guid id) {
            var response = await _client.GetAsync($"Elixirs/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }

            return await response.Content.DeserializeAsync<Elixir>();
        }
    }
}
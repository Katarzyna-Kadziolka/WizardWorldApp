using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WizardWorldApp.Data.Ingredients;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task<List<Ingredient>> GetIngredientsAsync(string name = null) {
            var query = new Dictionary<string, string>();
            if (name is not null) query.Add("Name", name);
            var response = await _client.GetAsync("Ingredients", query);
            return await response.Content.DeserializeAsync<List<Ingredient>>();
        }

        public async Task<Ingredient> GetIngredientByIdAsync(Guid id) {
            var response = await _client.GetAsync($"Ingredients/{id}");
            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }
            return await response.Content.DeserializeAsync<Ingredient>();
        }
    }
}
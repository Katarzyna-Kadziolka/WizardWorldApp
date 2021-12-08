using System;
using System.Net.Http;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        private HttpClient _client;

        public WizardWorldClient() {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://wizard-world-api.herokuapp.com");
        }
    }
}
using RestSharp;

namespace WizardWorldApp {
    public class WizardWorldClient {
        private RestClient _client;

        public WizardWorldClient() {
            _client = new RestClient("https://wizard-world-api.herokuapp.com");
        }
        
        
    }
}
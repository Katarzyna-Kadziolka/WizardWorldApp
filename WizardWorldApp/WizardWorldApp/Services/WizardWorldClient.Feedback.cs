using System.Net.Http.Json;
using System.Threading.Tasks;
using WizardWorldApp.Data.Feedback;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task PostFeedbackAsync(FeedbackCommand command) {
            var response = await _client.PostAsJsonAsync("Feedback", command);
        }
    }
}
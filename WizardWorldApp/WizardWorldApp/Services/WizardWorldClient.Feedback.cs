using System.Collections.Generic;
using System.Threading.Tasks;
using WizardWorldApp.Data.Feedback;
using WizardWorldApp.Extensions;

namespace WizardWorldApp.Services {
    public partial class WizardWorldClient {
        public async Task PostFeedbackAsync(FeedbackCommand command) {
            var query = new Dictionary<string, string>();
            if (command.Feedback is not null) query.Add("Name", command.Feedback);
            query.Add("SpellType", command.FeedbackType.ToString());
            if (command.EntityId is not null) query.Add("Incantation", command.EntityId.ToString());
            var response = await _client.GetAsync("Feedback", query);
        }
    }
}
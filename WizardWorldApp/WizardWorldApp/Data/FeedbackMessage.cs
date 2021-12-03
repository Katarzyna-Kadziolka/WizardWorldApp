using System;

namespace WizardWorldApp.Data {
    public class FeedbackMessage {
        public FeedbackType FeedbackType { get; set; }
        public string Feedback { get; set; }
        public Guid? EntityId { get; set; }
    }
    public enum FeedbackType {
        General = 0,
        Bug,
        DataError,
        Suggestion
    }
}
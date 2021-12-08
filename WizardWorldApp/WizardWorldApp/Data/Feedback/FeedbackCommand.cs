﻿using System;

namespace WizardWorldApp.Data.Feedback {
    public class FeedbackCommand {
        public FeedbackType FeedbackType { get; set; }
        public string Feedback { get; set; }
        public Guid? EntityId { get; set; }
    }
}
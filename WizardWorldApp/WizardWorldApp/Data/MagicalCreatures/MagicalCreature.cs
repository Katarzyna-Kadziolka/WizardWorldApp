using System;
using System.Collections.Generic;

namespace WizardWorldApp.Data.MagicalCreatures {
    public class MagicalCreature {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CreatureClassificationByMinistryOfMagic Classification { get; set; }
        public CreatureStatus Status { get; set; }
        public CreatureDangerLevel DangerLevel { get; set; }
        public ICollection<string> CreatureRelations { get; set; }
        public string NativeTo { get; set; }
    }
}
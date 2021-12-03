using System;
using System.Collections.Generic;

namespace WizardWorldApp.Data {
    public class MagicalCreature {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CreatureClassificationByMinistryOfMagic Classification { get; set; }
        public CreatureStatus Status { get; set; }
        public CreatureDangerLevel DangerLevel { get; set; }
        public ICollection<CreatureRelation> CreatureRelations { get; set; }
        public string NativeTo { get; set; }
    }
    
    public enum CreatureClassificationByMinistryOfMagic {
        None = 0
        //Beast, Being
    }
    public enum CreatureDangerLevel {
        // X, XX, XXX, XXXX, XXXXX
        None = 0
    }
    public class CreatureRelation {
        public Guid CreatureId { get; set; }
        public Guid RelatedCreatureId { get; set; }
    }
    public enum CreatureStatus {
        None = 0
    }
}
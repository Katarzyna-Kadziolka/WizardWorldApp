using System;
using System.Collections.Generic;

namespace WizardWorldApp.Data {
    public class House {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string HouseColours { get; set; }
        public string Founder { get; set; }
        public string Animal { get; set; }
        public string Element { get; set; }
        public string Ghost { get; set; }
        public string CommonRoom { get; set; }
        public ICollection<HouseHead> Heads { get; set; }
        public ICollection<Trait> Traits { get; set; }
    }
    public class HouseHead {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid HouseId { get; set; }
    }
    public class Trait {
        public Guid Id { get; set; }
        public TraitName Name { get; set; }
        public Guid HouseId { get; set; }
    }
    public enum TraitName {
        None = 0
    }
}
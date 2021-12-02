using System;

namespace WizardWorldApp.Data {
	public class Spell {
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Incantation { get; set; }
		public string Effect { get; set; }
		public bool? CanBeVerbal { get; set; }
		public SpellType Type { get; set; }
		public SpellLight Light { get; set; }
		public string Creator { get; set; }
	}
	public enum SpellLight {
		None = 0,
		Blue = 1,
		IcyBlue = 2,
		Red = 3,
		Gold = 4,
		Purple = 5,
		Transparent = 6,
		White = 7,
		Green = 8,
		Orange = 9,
		Yellow = 10,
		BrightBlue = 11,
		Pink = 12,
		Violet = 13,
		BlueishWhite = 14,
		Silver = 15,
		Scarlet = 16,
		Fire = 17,
		FieryScarlet = 18,
		Grey = 19,
		DarkRed = 20,
		Turquoise = 21,
		PsychedelicTransparentWave = 22,
		BrightYellow = 23,
		BlackSmoke = 24
	}
	public enum SpellType {
		None = 0,
		Charm = 1,
		Conjuration = 2,
		Spell = 3,
		Transfiguration = 4,
		HealingSpell = 5,
		DarkCharm = 6,
		Jinx = 7,
		Curse = 8,
		MagicalTransportation = 9,
		Hex = 10,
		CounterSpell = 11,
		DarkArts = 12,
		CounterJinx = 13,
		CounterCharm = 14,
		Untransfiguration = 15,
		BindingMagicalContract = 16,
		Vanishment = 17
	}
}
﻿namespace Pk3DSRNGTool
{
    public class PKM7 : Pokemon
    {
        public override GameVersion Version { get; protected set; } = GameVersion.Gen7;
        public override short Delay { get; protected set; }
        public byte NPC;
        public bool NoBlink;
        public bool IsPelago;

        public readonly static PokemonList Default = new PokemonList
        {
            Text = "-",
            List = new[]
            {
                new PKM7 { Conceptual = true, Species= 000, Level = 50, },
            }
        };

        public readonly static PokemonList[] Species_SM =
        {
            Default,
            new PokemonList
            {
                Text = "Legendary",
                List = new[]
                {
                   new PKM7 { Species = 785, Level = 60, ShinyLocked = true },              // Tapu Koko
                   new PKM7 { Species = 786, Level = 60, ShinyLocked = true },              // Tapu Lele
                   new PKM7 { Species = 787, Level = 60, ShinyLocked = true },              // Tapu Bulu
                   new PKM7 { Species = 788, Level = 60, ShinyLocked = true, NPC = 1, },    // Tapu Fini
                   new PKM7 { Species = 791, Level = 55, ShinyLocked = true, NPC = 6, Delay = 288, Version = GameVersion.SN,},   // Solgaleo
                   new PKM7 { Species = 792, Level = 55, ShinyLocked = true, NPC = 6, Delay = 282, Version = GameVersion.MN,},   // Lunala
                   new PKM7 { Species = 789, Level = 05, ShinyLocked = true, NPC = 3, Delay = 34, Gift = true},    // Cosmog
                   new PKM7 { Species = 772, Level = 40, NPC = 8, Delay = 34, Gift = true,},    // Type:Null
                   new PKM7 { Species = 801, Level = 50, ShinyLocked = true, NPC = 6, Delay = 34, Gift = true,},    // Magearna
                   new PKM7 { Species = 718, Level = 50, ShinyLocked = true, NPC = 3, Delay = 32, Gift = true, Forme = 1,},    // Zygarde-10%
                   new PKM7 { Species = 718, Level = 50, ShinyLocked = true, NPC = 3, Delay = 32, Gift = true, Forme = 0,},    // Zygarde-50%
                }
            },
            new PokemonList
            {
                Text = "In-Game Gift",
                List = new[]
                {
                    new PKM7 { Species = 142, Level = 40, NPC = 3, Delay = 34, Gift = true,},    // Aerodactyl
                    new PKM7 { Species = 137, Level = 30, NPC = 4, Delay = 34, Gift = true,},    // Porygon
                    new PKM7 { Species = 133, Level = 01, NPC = 5, Delay = 04, Gift = true, Syncable = false, Egg = true,},    // Gift Eevee Egg
                }
            },
            new PokemonList
            {
                Text = "Normal Stationary",
                List = new[]
                {
                    new PKM7 { Species = 739, Level = 18, NPC = 1, Delay = 04, NoBlink = true, },    // Crabrawler
                    new PKM7 { Species = 731, Level = 03, NPC = 1, Delay = 16, ShinyLocked = true, IVs = new[] { -1, -1, -1, -1, -1, 1 }, }, // Pikipek
                    new PKM7 { Species = 103, Level = 40, Forme = 1, Delay = 88, Unstable = true, },  // Exeggutor
                }
            },
            new PokemonList
            {
                Text = "Starters",
                List = new[]
                {
                    new PKM7 { Gift = true, Species = 722, Level = 5, Syncable = false, NPC = 5, Delay = 40, }, // Rowlet
                    new PKM7 { Gift = true, Species = 725, Level = 5, Syncable = false, NPC = 5, Delay = 40, }, // Litten
                    new PKM7 { Gift = true, Species = 728, Level = 5, Syncable = false, NPC = 5, Delay = 40, }, // Popplio
                }
            },
            new PokemonList
            {
                Text = "Poke Pelago",
                List = new[]
                {
                    new PKM7 { Gift = true, IsPelago = true, Species = 021, Level = 50, Syncable = false, Delay = 8, }, // Spearow
                    new PKM7 { Gift = true, IsPelago = true, Species = 041, Level = 50, Syncable = false, Delay = 8, }, // Zubat
                    new PKM7 { Gift = true, IsPelago = true, Species = 090, Level = 50, Syncable = false, Delay = 8, }, // Shellder
                    new PKM7 { Gift = true, IsPelago = true, Species = 278, Level = 50, Syncable = false, Delay = 8, }, // Wingull
                    new PKM7 { Gift = true, IsPelago = true, Species = 731, Level = 50, Syncable = false, Delay = 8, }, // Pikipek

                    new PKM7 { Gift = true, IsPelago = true, Species = 064, Level = 50, Syncable = false, Delay = 8, }, // Kadabra
                    new PKM7 { Gift = true, IsPelago = true, Species = 081, Level = 50, Syncable = false, Delay = 8, }, // Magnemite
                    new PKM7 { Gift = true, IsPelago = true, Species = 092, Level = 50, Syncable = false, Delay = 8, }, // Gastly
                    new PKM7 { Gift = true, IsPelago = true, Species = 198, Level = 50, Syncable = false, Delay = 8, }, // Murkrow
                    new PKM7 { Gift = true, IsPelago = true, Species = 426, Level = 50, Syncable = false, Delay = 8, }, // Drifblim
                    new PKM7 { Gift = true, IsPelago = true, Species = 703, Level = 50, Syncable = false, Delay = 8, }, // Carbink

                    new PKM7 { Gift = true, IsPelago = true, Species = 060, Level = 50, Syncable = false, Delay = 8, }, // Poliwag
                    new PKM7 { Gift = true, IsPelago = true, Species = 120, Level = 50, Syncable = false, Delay = 8, }, // Staryu
                    new PKM7 { Gift = true, IsPelago = true, Species = 127, Level = 50, Syncable = false, Delay = 8, }, // Pinsir
                    new PKM7 { Gift = true, IsPelago = true, Species = 661, Level = 50, Syncable = false, Delay = 8, }, // Fletchling
                    new PKM7 { Gift = true, IsPelago = true, Species = 709, Level = 50, Syncable = false, Delay = 8, }, // Trevenant
                    new PKM7 { Gift = true, IsPelago = true, Species = 771, Level = 50, Syncable = false, Delay = 8, }, // Pyukumuku

                    new PKM7 { Gift = true, IsPelago = true, Species = 227, Level = 50, Syncable = false, Delay = 8, }, // Skarmory
                    new PKM7 { Gift = true, IsPelago = true, Species = 375, Level = 50, Syncable = false, Delay = 8, }, // Metang
                    new PKM7 { Gift = true, IsPelago = true, Species = 707, Level = 50, Syncable = false, Delay = 8, }, // Klefki

                    new PKM7 { Gift = true, IsPelago = true, Species = 123, Level = 50, Syncable = false, Delay = 8, }, // Scyther
                    new PKM7 { Gift = true, IsPelago = true, Species = 131, Level = 50, Syncable = false, Delay = 8, }, // Lapras
                    new PKM7 { Gift = true, IsPelago = true, Species = 429, Level = 50, Syncable = false, Delay = 8, }, // Mismagius
                    new PKM7 { Gift = true, IsPelago = true, Species = 587, Level = 50, Syncable = false, Delay = 8, }, // Emolga

                    new PKM7 { Gift = true, IsPelago = true, Species = 627, Level = 50, Syncable = false, Delay = 8, Version = GameVersion.SN, }, // Ruffle
                    new PKM7 { Gift = true, IsPelago = true, Species = 629, Level = 50, Syncable = false, Delay = 8, Version = GameVersion.MN, }, // Vullaby
                }
            },
            new PokemonList
            {
                Text = "Fossils",
                List = new[]
                {
                    new PKM7 { Gift = true, Species = 138, Level = 20, NPC = 1, Delay = 40, }, // Omanyte
                    new PKM7 { Gift = true, Species = 140, Level = 20, NPC = 1, Delay = 40, }, // Kabuto
                    new PKM7 { Gift = true, Species = 142, Level = 20, NPC = 1, Delay = 40, }, // Aerodactyl
                    new PKM7 { Gift = true, Species = 345, Level = 20, NPC = 1, Delay = 40, }, // Lileep
                    new PKM7 { Gift = true, Species = 347, Level = 20, NPC = 1, Delay = 40, }, // Anorith
                    new PKM7 { Gift = true, Species = 408, Level = 20, NPC = 1, Delay = 40, }, // Cranidos
                    new PKM7 { Gift = true, Species = 410, Level = 20, NPC = 1, Delay = 40, }, // Shieldon
                    new PKM7 { Gift = true, Species = 564, Level = 20, NPC = 1, Delay = 40, }, // Tirtouga
                    new PKM7 { Gift = true, Species = 566, Level = 20, NPC = 1, Delay = 40, }, // Archen
                    new PKM7 { Gift = true, Species = 696, Level = 20, NPC = 1, Delay = 40, }, // Tyrunt
                    new PKM7 { Gift = true, Species = 698, Level = 20, NPC = 1, Delay = 40, }, // Amaura
                }
            },
        };

    }
}

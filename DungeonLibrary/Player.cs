namespace DungeonLibrary
{
    public class Player : Character
    {
        //fields - auto  & inherited

        //properties
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //constructors
        public Player(int life, string name, int hitChance, int block, int maxLife, Race characterRace, Weapon equippedWeapon) 
            : base(life, name, hitChance, block, maxLife)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }

        //methods
        public override decimal CalcDamage()
        {
            Random rand = new Random();
            int dmg = rand.Next(EquippedWeapon.MaxDamage - EquippedWeapon.MinDamage);
            return dmg;
        }

        public override decimal CalcHitChance()
        {
            decimal hit = base.CalcHitChance() + HitChance;
            return hit;
        }
        
        public string RaceDescription()
        {
            string desc = "";
            switch (CharacterRace)
            {
                case Race.Miqote:
                    desc = "This cat-like race possesses large ears and feline tails. They migrated to Eorzea " +
                        "during the Age of Endless Frost in the Fifth Umbral Era. Miqo'te are divided into Seekers " +
                        "of the Sun and Keepers of the Moon.";
                    break;
                case Race.Viera:
                    desc = "Introduced in Shadowbringers, the Viera were originally female only. \n" +
                        "Male Viera were added with Endwalker. They are a superficially leporine race, \n" +
                        "with long fur-covered ears and lithe features. Viera are divided into Rava and Veena clans.";
                    break;
                case Race.Aura:
                    desc = "Introduced in Heavensward, the Au Ra are a superficially dragon-like race with horns, scales and tails." +
                        "The Au Ra are divided into Raen and Xaela clans.";
                    break;
                case Race.Elezen:
                    desc = "This elf-like race is tall and slender. They have slightly longer life spans when" +
                        " compared to the other races. The Elezen believe that they originated in Eorzea, and " +
                        "that it was once their sole dominion. The Elezen are divided into Wildwood and Duskwight clans.";
                    break;
                case Race.Roegadyn:
                    desc = "The Roegadyn's massive muscular frames make them distinguishable from afar. Descended from " +
                        "maritime people that roamed the northern seas, they are sometimes considered a barbaric race. " +
                        "Roegadyn are divided into Sea Wolves and Hellsguard.";
                    break;
                case Race.Hyur:
                    desc = "This human-like race is average in height and build. The Hyur are the most populous and widespread " +
                        "of the playable races.The Hyur are divided into Midlanders and Highlanders.";
                    break;
                case Race.Lalafell:
                    desc = "The Lalafell are a diminutive race from seas south of Eorzea. They possess child-like appearances " +
                        "and cheerful attitudes. Lalafell are divided into Plainsfolk and Dunesfolk.";
                    break;
                case Race.Hrothgar:
                    desc = "Introduced in Shadowbringers, the Hrothgar can be played as male only. They are a large " +
                        "leonine race with a fearsome bestial appearance.Female Hrothgar will be added some time " +
                        "after the release of Endwalker. Hrothgar are divided into Helions and The Lost clans.";
                    break;
                default:
                    break;
            }
            return desc;
        }

        public override string ToString()
        {
            return String.Format
                (
                $"{Name}\n" +
                $"Race: {CharacterRace}\n" +
                $"Description: {RaceDescription()}\n\n" +
                $"Life: {Life} / {MaxLife}\n" +
                $"Hit Chance: {HitChance}\n" +
                $"Block: {Block}\n" +
                $"Weapon: {EquippedWeapon}\n" 
                );
        }

    }
}



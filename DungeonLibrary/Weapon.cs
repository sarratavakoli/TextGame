namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _weaponType;

        //properties
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int BonusHitChance { get { return _bonusHitChance; } set { _bonusHitChance = value; } }
        public bool IsTwoHanded { get { return _isTwoHanded; } set { _isTwoHanded = value; } }
        public WeaponType WeaponType { get { return _weaponType; } set { _weaponType = value; } }   

        //Include a business rule that ensures MinDamage is less than or equal to MaxDamage.
        //If someone tries to assign a value greater than MaxDamage, then assign MinDamage the value of MaxDamage.

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= _maxDamage && value > 0)
                {
                    //if the min damage is less than or equal to max damage
                    //we will allow them to set the value
                    _minDamage = value;
                }
                else
                {
                    //if min damage is greater than max damage 
                    //set min damage to max damage
                    _minDamage = 1;
                }
            }
        }

        //constructors
        //In the body of the Fully Qualified Constructor, ensure that the assignment for MaxDamage happens before MinDamage.
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType weaponType)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            WeaponType = weaponType;
        }

        //methods
        public override string ToString()
        {
            return String.Format($"{Name}\n{WeaponType} ({(IsTwoHanded ? "Two Handed" : "")})\nDamage: {MinDamage:n} - {MaxDamage:n}\n" +
                $"Bonus Hit Chance: {BonusHitChance}\n");
        }
    }
}
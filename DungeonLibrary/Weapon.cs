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

        //properties
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int BonusHitChance { get { return _bonusHitChance; } set { _bonusHitChance = value; } }
        public bool IsTwoHanded { get { return _isTwoHanded; } set { _isTwoHanded = value; } }

        //Include a business rule that ensures MinDamage is less than or equal to MaxDamage.
        //If someone tries to assign a value greater than MaxDamage, then assign MinDamage the value of MaxDamage.

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= _maxDamage)
                {
                    //if the min damage is less than or equal to max damage
                    //we will allow them to set the value
                    _minDamage = value;
                }
                else
                {
                    //if min damage is greater than max damage 
                    //set min damage to max damage
                    _minDamage = _maxDamage;
                }
            }
        }

        //constructors
        //In the body of the Fully Qualified Constructor, ensure that the assignment for MaxDamage happens before MinDamage.
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        //methods
        public override string ToString()
        {
            return String.Format($"Name: {Name}\tDamage: {MinDamage:n} - {MaxDamage:n}\t" +
                $"Bonus Hit Chance: {BonusHitChance}\t{(IsTwoHanded ? "Two Handed" : "Not Two Handed")}");
        }
    }
}
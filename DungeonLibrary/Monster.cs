namespace DungeonLibrary
{
    public class Monster : Character
    {
        //fields
        private int _minDamage;

        //properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        //custom business rule
        public int MinDamage
        {
            get { return _minDamage; }
            set 
            { 
                _minDamage = value <= MaxDamage && value >= 0 ? value : 0;
            }
        }

        //constructors
        public Monster(int life, string name, int hitChance, int block, int maxLife, int minDamage , int maxDamage, string description)
            : base(life, name, hitChance, block, maxLife)
        { }

        //methods
        public override string ToString()
        {
            return base.ToString() + $"Race Description: {Description}\nDamage: {MinDamage} - {MaxDamage}";
        }

        public override decimal CalcDamage()
        {
            Random rand = new Random();
            decimal dmg = rand.Next(MaxDamage - MinDamage);
            return dmg;
        }
    }
}

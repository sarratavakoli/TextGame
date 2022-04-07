namespace DungeonLibrary
{
    public class Character
    {
        //fields
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        
        //properties
        public string Name { get { return _name; } set { _name = value; } }
        public int HitChance { get { return _hitChance; } set { _hitChance = value; } }
        public int Block { get { return _block; } set { _block = value; } }
        public int MaxLife { get { return _maxLife; } set { _maxLife = value; } }
        //Include a business rule that ensures life is less than or equal to MaxLife.
        //If someone tries to assign a value greater than MaxLife, then assign life the value of MaxLife.
        public int Life
        {
            get { return _life; }
            set 
            { 
                if (_life <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }

        //constructors
        //Fully Qualified CTOR
        //In the body of the Fully Qualified Constructor, ensure that the assignment for MaxLife happens before Life.
        public Character(int life, string name, int hitChance, int block, int maxLife)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
        }
        
        public Character() { }

        //method
        public override string ToString()
        {
            return string.Format($"Name: {Name}\tLife: {Life}\tHit Chance: {HitChance}\tBlock: {Block}\tMax Life: {MaxLife}");
        }
        
        //CalcBlock() – returns the value of Block
        public decimal CalcBlock()
        {
            //decimal Block = .40m;
            return Block;
        }

        //CalcHitChance() – returns the value of HitChance
        public decimal CalcHitChance()
        {
            //decimal HitChance = .90m;
            return HitChance;
        }

        //CalcDamage() – returns 0
        public decimal CalcDamage()
        {
            decimal Damage = 0;
            return Damage;
        }




    }
}
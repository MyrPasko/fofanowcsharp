using System.ComponentModel;

namespace D_OOP
{
    public class Character
    {
        public int Health { get; private set; }
        
        public string Race { get; private set; }
        public int Armor { get; private set; }

        public Character(string race)
        {
            Race = race; 
        }

        public Character(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            Health -= damage;

        }
    }
}
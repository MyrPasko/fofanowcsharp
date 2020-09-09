using System.ComponentModel;

namespace D_OOP
{
    public class Character
    {
        private readonly  int Speed = 10;
        private int Health { get; set; }
        private string Race { get; set; }
        private int Armor { get; set; }

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

        public int GetSpeed()
        {
            return Speed;
        }
    }
}
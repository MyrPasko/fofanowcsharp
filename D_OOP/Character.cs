using System.ComponentModel;

namespace D_OOP
{
    public class Character
    {
        private readonly  int Speed = 10;
        private int Health { get; set; }
        private Race Race { get; set; }
        private int Armor { get; set; }

        public Character(Race race)
        {
            Race = race;
            Armor = 30;
        }

        public Character(Race race, int armor)
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

        public Race GetRace()
        {
            return Race;
        }
    }
}
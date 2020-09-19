using System;
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

        public Character(string name, int armor)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name can't be null");
            }

            if (armor < 0 || armor > 100)
            {
                throw new ArgumentException("Armor can't be less than 0 and more than 100");
            }
        }

        public void Hit(int damage)
        {
            if (Health == 0)
            {
                throw new InvalidOperationException("Character is dead already.");
            }
            
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
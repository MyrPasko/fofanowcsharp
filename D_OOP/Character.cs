namespace D_OOP
{
    public class Character
    {
        public int Health { get; private set; }

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            Health -= damage;

        }
    }
}
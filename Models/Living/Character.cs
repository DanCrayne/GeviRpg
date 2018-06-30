namespace GeviRpg.Models
{
    public class Character : LivingThing
    {
        public string Name { get; set; }

        public string ToString() 
        {
            return $"Name: {Name}\nHP: {Hitpoints.ToString()}";
        }
    }
}
namespace GeviRpg.Models
{
    public abstract class LivingThing 
    {
        public int Hitpoints { get; set; }
        public Dimensions Size { get; set; }
        public Weight Weight { get; set; }
    }
}
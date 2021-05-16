namespace Viewer
{
    public class PriceMod
    {
        PriceMod(float benefit, float firstClass)
        {
            Benefit = benefit;
            FirstClass = firstClass;
        }
        public PriceMod()
        {
        }

        public int Id { get; set; }
        public float Benefit { get; set; }
        public float FirstClass { get; set; }

    }
}

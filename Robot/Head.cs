namespace Robot
{
    public class Head
    {
        public Face face { get; set; }
        public Neck neck { get; set; }
        public Hair hair { get; set; }
        public List<Ear>? ears { get; set; }

        public Head(Face face, Neck neck, Hair hair, List<Ear> ears)
        {
            this.face = face;
            this.neck = neck;
            this.hair = hair;
            this.ears = ears;
        }

        public Head()
        {
        }

        internal void TurnOnEarLight(string side)
        {
            foreach (var ear in ears)
            {
                if (ear.Side.Equals(side) || side.Equals("both"))
                {
                    ear.LightOn();
                }


            }
        }

        internal bool IsEarLightOn(string v)
        {
            throw new NotImplementedException();
        }
    }
}
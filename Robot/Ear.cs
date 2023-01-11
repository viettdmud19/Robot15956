namespace Robot
{
   
    public class Ear : CommonBase
    {
        public string Side { get; set; }
        public string Light { get; private set; }

        internal void LightOn()
        {
            this.Light = "red";
        }
    }
}
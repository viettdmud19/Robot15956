namespace Robot
{
    public class Eye : CommonBase
    {
        

        public ConNguoi ConNguoi { get; set; }
        public MiMat? MiMat { get; set; }
        public TrongMat? TrongMat { get; set; }
        public string Side { get; set; }
        public Eye(ConNguoi conNguoi, MiMat miMat, TrongMat trongMat, string side)
        {
            this.ConNguoi = conNguoi;
            this.MiMat = miMat;
            this.TrongMat = trongMat;
            this.Side = side;
        }

        public Eye()
        {
        }

        internal Eye OpenEye(Eye eye, string side)
        {
            eye.ConNguoi.Width = 100;
            eye.ConNguoi.Height = 100;

            eye.Side = side;
            return eye;
        }

    }
}
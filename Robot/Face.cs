namespace Robot
{
    public class Face : CommonBase
    {
        private List<Eye> _eyes { get; set; }
        private Mounth _mounth { get; set; }

        public Face(List<Eye> eyes, Mounth mounth)
        {
            this._eyes = eyes;
            this._mounth = mounth;
        }

        public Face()
        {
            Eye rEye = new Eye();
            Eye lEye = new Eye();
            this._eyes = new List<Eye>() { lEye, rEye };
            this._mounth = new Mounth();
        }

        internal bool HasEye()
        {
            return this._eyes.Count > 0;
        }

        internal void OpenEyes()
        {
            SetEyesStatusInternal("red");
        }

        internal void CloseEyes()
        {
            SetEyesStatusInternal("black");
        }

        private void SetEyesStatusInternal(string color)
        {
            foreach (Eye eye in this._eyes)
            {
                eye.Color = color;
            }
        }

        internal bool IsOpenEyes()
        {
            foreach(Eye eye in this._eyes)
            {
                if (eye.Color.Equals("black"))
                    return false;
            }
            return true;
        }
    }
}
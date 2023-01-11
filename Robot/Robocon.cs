namespace Robot
{
    internal class Robocon
    {
        public Head head { get; set; }
        public Body body { get; set; }
        public Leg leg { get; set; }
        public Hand hand { get; set; }
        public Robocon(Head head, Body body, Leg leg, Hand hand)
        {
            this.head = head;
            this.body = body;
            this.leg = leg;
            this.hand = hand;
        }
    }
}
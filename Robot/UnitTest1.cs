using System.Security.Cryptography.X509Certificates;

namespace Robot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EyesTest()
        {
            var eyes = new List<Eye>();
            var eyeLeft = new Eye();
            var eyeRight = new Eye();
            eyes.Add(eyeLeft);
            eyes.Add(eyeRight);
            var mounth = new Mounth();
            var face = new Face(eyes, mounth);

            Assert.IsTrue(face.HasEye());
        }
        [TestMethod]
        public void FaceHaveEyesTest()
        {
            var face = new Face();

            Assert.IsTrue(face.HasEye());


        }

        [TestMethod]
        public void OpenEyesTest()
        {
            var face = new Face();
            face.OpenEyes();

            Assert.IsTrue(face.HasEye());
            Assert.AreEqual(face.IsOpenEyes(), true);

            face.CloseEyes();
            Assert.AreEqual(face.IsOpenEyes(), false);

        }
        [TestMethod]
        public void TurnOnEarsLightTest()
        {
            var head = new Head();
            head.TurnOnEarLight("left");

            Assert.AreEqual(head.IsEarLightOn("left"), true);

            head.TurnOnEarLight("right");

            Assert.AreEqual(head.IsEarLightOn("right"), true);

            head.TurnOnEarLight("both");

            Assert.AreEqual(head.IsEarLightOn("both"), true);

            Assert
        }


    }

}
using Figures;
namespace Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestConstructor_WithNegativeRadius()
        {
            try
            {
                Circle circle = new Circle(-5.3);
            }
            catch(Exception e) {
                Assert.IsInstanceOfType(e, typeof(System.ArgumentException));
            }
            
        }

        [TestMethod]
        public void TestConstructor_WithZeroRadius()
        {
            try
            {
                Circle circle = new Circle(0);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(System.ArgumentException));
            }

        }

        [TestMethod]
        public void TestConstructor_WithPositiveRadius()
        {
            Assert.IsInstanceOfType(new Circle(2.83), typeof(Circle));
        }

        [TestMethod]
        public void Test_Area()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(circle.Area(), 78.53981633974483);
        }
    }
}
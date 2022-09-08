using Figures;
namespace Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestConstructor_TriangleDoesNotExist()
        {
            try
            {
                Triangle triangle = new Triangle(3, 4, 5);
            } catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(System.ArgumentException));
            }
        }

        [TestMethod]
        public void TestConstructor_TriangleExists()
        {
            Assert.IsInstanceOfType(new Triangle(10, 3, 8), typeof(Triangle));
        }
    }
}
using Tyuiu.PlesovskikhBA.Sprint4.Task7.V13.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint4.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "159357246";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
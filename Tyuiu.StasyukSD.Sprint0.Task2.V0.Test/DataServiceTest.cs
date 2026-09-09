using Tyuiu.StasyukSD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.StasyukSD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестмрования, методов из библиотеки
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            //Вызываем клвсс Asset и вызываем метод AreEqual
            Assert.AreEqual("Привет..., Игорь", res);
        }
    }
}

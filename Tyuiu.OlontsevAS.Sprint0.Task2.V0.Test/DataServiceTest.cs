using Tyuiu.OlontsevAS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.OlontsevAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //Область создания методов тестирования, методов из библиотеки
            var name = "Андрей";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assent и метод AreEqual
            Assert.AreEqual("Привет..., Андрей", res);
        }
    }
}

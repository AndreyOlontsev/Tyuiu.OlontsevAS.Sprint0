using Tyuiu.OlontsevAS.Sprint0.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        //Вызов класса DataService и метода GetMessage
        //из библиотеки Tyuiu.OlontsevAS.Sprint0.Task2.V0.Lib
        Console.WriteLine(DataService.GetMessage("Андрей"));
        Console.ReadKey();
    }
}
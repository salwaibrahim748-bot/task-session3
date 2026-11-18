using static task3.Class1;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 13
            Duck myDuck = new Duck();
            IFlyable flyingDuck = myDuck;
            Console.WriteLine(flyingDuck.Move());
            ISwimmable swimmingDuck = myDuck;
            Console.WriteLine(swimmingDuck.Move()); 
            #endregion
        }
    }
}

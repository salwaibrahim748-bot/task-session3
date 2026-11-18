using System.Numerics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static task2_session3.Animal;

namespace task2_session3
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 9
            Animal animal = new Dog();
            animal.Speak();  // predicted output is dogs braks
            animal.Type();   // type is dog
            #endregion

            #region 10
            object text = "hello";
            Printer.Print(text);   // Printed as OBJECT: hello
            Printer.Print((dynamic)text);  //Printed as STRING: hello
            #endregion
            // question
            // Early Binding Calls: animal.Type() & Printer.Print(text)
            //Explanation: These are early binding because the compiler can figure out and lock down exactly which method to call during the compile-time,
            //based purely on the declared reference types(Animal and object).

            //Late Binding Calls: animal.Speak() &Printer.Print((dynamic)text)
            //Explanation: These are late binding because the actual method choice is postponed until runtime.For Speak(),
            //it relies on the real object type in memory thanks to override, and for the second one,
            //the dynamic keyword bypasses compile - time checks so it decides the correct method when the program is running.
        }
    }
}

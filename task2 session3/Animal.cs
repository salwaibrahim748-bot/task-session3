using System;
using System.Collections.Generic;
using System.Text;

namespace task2_session3
{
    #region 6 class animal
    public class Animal
    {
        public virtual void Speak()  // virtual => في الدالة اللي جوه الاب عشان نسمح للأبناء بتعديلها.
        {
            Console.WriteLine("Animal makes a sound");
        }
        public void Type()
        {
            Console.WriteLine("Any animal");
        }
    }
    #endregion

    #region 7 class dog
    public class Dog : Animal
    {
        public override void Speak()  //      عشان نعدل بالفعل ونعمل "تعديل" للسلوك القديم.
        {
            Console.WriteLine("dogs braks");
        }
        public new void Type()
        {
            Console.WriteLine("type is dog"); //"نخفي" دالة الأب ونعمل دالة جديدة تماماً في الابن تحمل نفس الاسم بالصدفة أو كاسم متشابه، بس ملهاش علاقة بدالة الأب.
        }
    }
    #endregion

    #region 8 static class
    public static class Printer
    {
        public static void Print(object obj) // دالة لاستقبال أي نوع بيانات (Object)
        {
            Console.WriteLine("Printed as OBJECT:" + obj);
        }
        public static void Print(string str) // دالة مخصصة لاستقبال النصوص
        {
            Console.WriteLine("Printed as STRING: " + str);
        }
    }
    #endregion
}

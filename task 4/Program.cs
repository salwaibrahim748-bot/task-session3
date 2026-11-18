namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 16
            Money m1 = new Money(100, "USD");
            Money m2 = new Money(100, "USD");
            Console.WriteLine($"m1 == m2: {m1 == m2}"); // تساوي القيم 
            Console.WriteLine($"ReferenceEquals(m1, m2): {ReferenceEquals(m1, m2)}"); // اختلاف المرجع 
            Console.WriteLine($"m1 HashCode: {m1.GetHashCode()}");
            Console.WriteLine($"m2 HashCode: {m2.GetHashCode()}");
            Console.WriteLine($"ToString: {m1.ToString()}");
            Console.WriteLine($"ToString: {m2.ToString()}");
            #endregion

            #region 17
            Money2 m3 = new Money2(100, "USD");
            Money2 m4 = new Money2(100, "USD");
            Console.WriteLine($"Class m3 == m4: {m3 == m4}");
            Console.WriteLine($"Class ReferenceEquals: {ReferenceEquals(m3, m4)}");
            Console.WriteLine($"Class HashCode m3: {m3.GetHashCode()}");
            Console.WriteLine($"Class ToString: {m3.ToString()}");
            #endregion

            #region 18
            Money m5 = m1 with { Currency = "EUR" }; // غيرت العمله فقط
            Console.WriteLine(m5);
            #endregion

            #region 19
            HashSet<Money> moneySet = new HashSet<Money>();
            moneySet.Add(m1);
            moneySet.Add(m2);

            Console.WriteLine($"HashSet Count: {moneySet.Count}"); 
            #endregion
        }
    }
}

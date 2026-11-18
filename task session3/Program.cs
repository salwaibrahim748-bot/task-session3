namespace task_session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            Address originalAddress = new Address("Alexandria");
            Customer original = new Customer("Ahmed", originalAddress);
            Customer shallow = original.ShallowCopy();
            Customer deep = original.DeepCopy();
            Console.WriteLine("Before Changing Original Address ");
            Console.WriteLine($"Original: {original.Address.City} \n Shallow: {shallow.Address.City} \n Deep: {deep.Address.City} ");

            original.Address.City = "Cairo";

            Console.WriteLine("After Changing Original Address to Cairo");
            Console.WriteLine($"Original: {original.Address.City} \n Shallow: {shallow.Address.City} \n Deep: {deep.Address.City} "); 
            #endregion

        }
    }
}

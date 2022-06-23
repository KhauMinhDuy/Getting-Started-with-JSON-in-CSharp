using System;

namespace m2
{
    class Program
    {
        public static void Main(string[] args)
        {
            SerializeDeserializeDemo.Show();
            Console.WriteLine("----------------------------------------------");
            ObjectReferencesDemo.Show();
            Console.WriteLine("----------------------------------------------");
            DynamicDemo.Show();
        }
    }
}

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
            Console.WriteLine("----------------------------------------------");
            SerializeObjectsDemo.Show();
            Console.WriteLine("----------------------------------------------");
            DeserializeObjectsDemo.Show();
            Console.WriteLine("----------------------------------------------");
            JsonSerializerDemo.Show();
            Console.WriteLine("----------------------------------------------");
            JsonTextReaderDemo.Show();
            Console.WriteLine("----------------------------------------------");
            JsonTextWriterDemo.Show();
            Console.WriteLine("----------------------------------------------");
            JsonDatesDemo.Show();
            Console.WriteLine("----------------------------------------------");
            DeserializeErrorDemo.Show();
            Console.WriteLine("----------------------------------------------");
            ConversionErrorsDemo.Show();
            Console.WriteLine("----------------------------------------------");
            HandleConversionErrorsDemo.Show();
        }
    }
}

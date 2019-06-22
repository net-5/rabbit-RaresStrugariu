using System;

namespace Rabbit
{
   class Program
   {
      static void Main(string[] args)
      {
         Rabbit rabbit1 = new Rabbit();
         Console.Write("Enter the eyes colour: ");
         rabbit1.Eyes = Console.ReadLine();
         Console.Write("Enter the fur colour: ");
         rabbit1.Fur = Console.ReadLine();
         Console.Write("Enter the rabbit gender: ");
         rabbit1.Gender = Console.ReadLine();
         Console.Write("Enter the rabbit birthdate: ");
         rabbit1.BirthDate = int.Parse(Console.ReadLine());
         Console.WriteLine("\n");
         Console.WriteLine(rabbit1.Info());
         Console.WriteLine(rabbit1.Age());
         Console.WriteLine(rabbit1.Ability());
         Console.WriteLine(rabbit1.Sleep());
         Console.WriteLine(rabbit1.Eat());
         
      }
   }
}

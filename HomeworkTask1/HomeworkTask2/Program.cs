using System;



namespace HomeworkTask2
{
    

    class Program
    {
        static string removeExtraSpace(string example)
        {
            string trimmed = String.Join(" ", example.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));

            return trimmed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string example = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            Console.WriteLine(removeExtraSpace(example));


            Console.ReadLine();
        }
    }
}

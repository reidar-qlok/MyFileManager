namespace MyFileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\reidar\OneDrive\Skrivbord\myfile.txt";
            //string[] lines = File.ReadAllLines(filePath);

            //List<string> Lines = new List<string>();
            //Lines = File.ReadAllLines(filePath).ToList();
            ////foreach (var item in Lines)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Lines.Add("Chas Academy NET24");
            //File.WriteAllLines(filePath, Lines);

            //List<string> Lines2 = new List<string>();
            //Lines2 = File.ReadAllLines(filePath).ToList();
            //foreach (var item in Lines2)
            //{
            //    Console.WriteLine(item);
            //}
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadKey();
        }
        static async Task<int> ReadFile(string file)
        {
            int lenght = 0;
            Console.WriteLine("Fil läsningen börjar här");
            using (StreamReader reader = new StreamReader(file))
            {
                // Läs in alla tecken i filen
                string result = await reader.ReadToEndAsync();
                lenght = result.Length;
            }
            Console.WriteLine("Fil läsningen är klar");
            return lenght;
        }
        static async void CallMethod()
        {
            string filePath = @"C:\Users\reidar\OneDrive\Skrivbord\myfile.txt";
            Task<int> myTask = ReadFile(filePath);
            Console.WriteLine("Förste jobbet har startat");
            Console.WriteLine("Andra jobbet har startat");
            int len = await myTask;
            Console.WriteLine("Antal tecken i filen: " + len);

            Console.WriteLine("Första jobbet är klart");
            Console.WriteLine("Andra jobbet är klart");

        }

    }
}

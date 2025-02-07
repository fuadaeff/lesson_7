using System.Reflection.Emit;

namespace FindigYigimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int week = 3;
            int day = 7;
            int week_counter = 1;
            int[,] team_1 = new int[week, day];
            int[,] team_2 = new int[week, day];
            int[,] result = new int[week, day];
            Console.WriteLine("1-ci qrupun yigimini daxil edin:");
            for (int i = 0; i < week; i++) {
                Console.WriteLine($"{week_counter} heftenin yigimini qeyd edin:");
                for (int j = 0; j < day; j++)
                {
                    
                Label:
                    bool is_integer = int.TryParse(Console.ReadLine(), out int findig);
                    if (!is_integer)
                    {
                        Console.WriteLine("Duzgun eded daxil edin!");
                        goto Label;
                    }
                    team_1[i, j] = findig;
                        
                }
                week_counter++;
            }
            week_counter = 1;
            Console.WriteLine("2-ci qrupun yigimini daxil edin:");
            for (int k = 0; k < week; k++)
            {
                Console.WriteLine($"{week_counter} heftenin yigimini qeyd edin:");
                for (int l = 0; l < day; l++)
                {

                Label1:
                    bool is_integer = int.TryParse(Console.ReadLine(), out int findig);
                    if (!is_integer)
                    {
                        Console.WriteLine("Duzgun eded daxil edin!");
                        goto Label1;
                    }
           
                    team_2[k, l] = findig;

                }
                week_counter++;

            }
            for (int m = 0; m < week; m++)
            {
                for (int n = 0; n < day; n++)
                {
                    result[m, n] = team_1[m, n] + team_2[m, n];
                }
            }
            for (int m = 0; m < week; m++)
            {
                for (int n = 0; n < day; n++)
                {
                    Console.Write(team_1[m, n] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int m = 0; m < week; m++)
            {
                for (int n = 0; n < day; n++)
                {
                    Console.Write(team_2[m, n] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Iki qrup birlikde yigim etseydi:");
            for (int m = 0; m < week; m++)
            {
                for (int n = 0; n < day; n++)
                {
                    Console.Write(result[m, n] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

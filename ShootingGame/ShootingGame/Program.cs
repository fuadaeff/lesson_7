using System.Reflection.Emit;

namespace ShootingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player_count = 4;
            int shoot_count = 5;
            int counter_player = 1;
            string player_name = " ";
            string p_name = " ";
            int max = 0;
            int MAX = 0;
            int count_fifty = 0;
            int[,] scores = new int[player_count,shoot_count];
            for (int i = 0; i < player_count; i++)
            {            
                int sum = 0;
                count_fifty = 0;
                Console.WriteLine($"{counter_player}-ci oyuncunun melumatlarini daxil edin:");
                Console.WriteLine("Oyuncunun qazandigi xallari yazin:");
                for (int j = 0; j < shoot_count; j++)
                {
                   
                Label:
                    bool is_integer = int.TryParse(Console.ReadLine(), out int score);
                    if (!is_integer)
                    {
                        Console.WriteLine("Duzgun eded daxil edin!");
                        goto Label;
                    }
                    if (score == 50)
                    {
                        count_fifty++;
                    }
                    scores[i,j] = score;
                    sum = sum + score;
                }
                if (count_fifty > MAX)
                {
                    MAX = count_fifty;
                    p_name = counter_player.ToString();
                }
                if (sum > max)
                {
                    max = sum;
                    player_name = counter_player.ToString();
                }
                counter_player++;
            }
            Console.WriteLine($"{player_name}-ci oyuncu umumi xallar uzre qalibdir: {max}");
            Console.WriteLine($"{p_name}-ci oyuncu hedefe deyme uzre qalibdir: {MAX}({MAX} defe 50 bal qazanib.)");
            







            //for (int i = 0; i < player_count; i++)
            //{
               
            //    for (int j = 0; j < shoot_count; j++)
            //    {
            //        Console.Write(scores[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}

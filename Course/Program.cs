using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<User> set = new HashSet<User>();

            Console.Write("How many courses the instructor have? ");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"How many students for course {i}? ");
                int n = int.Parse(Console.ReadLine());
                for (int g = 1; g <= n; g++)
                {
                    set.Add(new User { UniCod = int.Parse(Console.ReadLine()) });
                }
            
            
            
            }
            Console.Write("Total students: " + set.Count);
        }
    }
}
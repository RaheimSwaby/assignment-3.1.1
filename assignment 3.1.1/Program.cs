using System.Text;

namespace assignment_3._1._1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine(ReturnByTwosEvens(100));
            }

            static string ReturnByTwosEvens(int numAmount)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 2; i < numAmount; i += 2)
                {
                    sb.Append(i);
                    sb.Append(' ');
                }
                return sb.ToString();
            }

        }
    }

   

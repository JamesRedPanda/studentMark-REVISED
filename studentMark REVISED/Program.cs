namespace studentMark_REVISED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool finished = false;
            while (finished == false) 
            {
                string name = studentDetails();
                studentResults(name);

                Console.WriteLine("Press 1 to exit, or any key to enter next student grade");
                string exit = Console.ReadLine();
                Console.Clear();
                if (exit == "1") finished = true;
            }
        }

        static string studentDetails()
        {
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            bool retryAllowed = true;
            return name;
            
        }
        static bool retryAllowed(string name)
        {
            bool retry = true;
            return retry;
        }

        static double Test1 (string name)
            {
            double test1 = -1;
            Console.WriteLine($"Enter {name}'s score for test 1");
            string input = Console.ReadLine();
            if (double.Parse(input) >= 0.0 && double.Parse(input) <= 100.0)
            {
                test1 = double.Parse(input);
                return test1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter an integer between 0 and 99");
                Test1(name);
            }
            return test1;
        }

        static double Test2(string name)
        {
            double test2 = -1;
            Console.WriteLine($"Enter {name}'s score for test 2");
            string input = Console.ReadLine();
            if (double.Parse(input) >= 0.0 && double.Parse(input) <= 100.0)
            {
                test2 = double.Parse(input);
                return test2;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter an integer between 0 and 99");
                Test2(name);
            }
            return test2;
        }

        static double Project(string name)
        {
            double project = -1;
            Console.WriteLine($"Enter {name}'s score for project");
            string input = Console.ReadLine();
            if (double.Parse(input) >= 0.0 && double.Parse(input) <= 100.0)
            {
                project = double.Parse(input);
                return project;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter an integer between 0 and 99");
                Project(name);
            }
            return project;
        }
        static double calcFinal(string name)
        {
            double test1 = Test1(name);
            double test2 = Test2(name);
            double project = Project(name);
            double final = (test1 * .3) + (test2 * .3) + (project *.4);
            return final;
        }

        static void studentResults(string name)
        {
           
            double final = calcFinal(name);
            
            Console.WriteLine($"Results for {name}");
            Console.WriteLine($"Final: {final}");
            //while (true)
            //{
            //    if (final < 50)
            //    {
            //        Console.Clear();
            //        Console.WriteLine($"Final mark is less than 50. {name} qualifies for retry");
            //        studentResults(name);
            //        break;
            //    }
            //}
            switch (final)
            {
                case > 75:
                    Console.WriteLine("PD!");
                    break;
                case > 66:
                    Console.WriteLine("Good");
                    break;
                case > 50:
                    Console.WriteLine("Pass");
                    break;
                default:
                    Console.WriteLine("Fail!");
                    break;
            }
        }
    }
}

namespace Users
{
    internal class Program
    {
       static bool stop = false;
        static void tryagain()
        {
            Console.WriteLine("Do you want anything else if want enter y of entet n");
            char choose = char.Parse(Console.ReadLine());
            if (choose == 'y' || choose == 'Y')
                Console.WriteLine("=========================================");
            else
            {
                stop = true;
                Console.WriteLine("Good By ");
            }
                
             
        }
        static void Main(string[] args)
        {
            
            User user = new User();
            List<User> users = new List<User>();
            int choose;
            while (stop !=true)
            {
                Console.WriteLine("1-Add User");
                Console.WriteLine("2-Update Data of User");
                Console.WriteLine("3-Delete User");
                Console.WriteLine("4-Print All user");

                string input = Console.ReadLine();
                if (int.TryParse(input, out choose))
                {
                    if (choose == 1)
                    {
                        user.Adduser(users);
                    }
                    else if (choose == 2)
                    {
                        user.UpdateUser(users);
                    }

                    else if (choose == 3)
                    {
                        user.DeleteUser(users);
                    }
                    else if (choose == 4)
                    {
                        user.PrintAllUser(users);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Correct Number");
                    }

                    tryagain();
                }
                else
                {
                    Console.WriteLine("Unvaled Input Please Enter Number");
                }
            }
        }
    }
}

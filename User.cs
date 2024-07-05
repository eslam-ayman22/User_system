using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Add User
        public void Adduser(List<User> users)
        {
            Console.WriteLine("===================Add User==========================");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter PhoneNumber: ");
            string phone = Console.ReadLine();

            var newuser = new User
            {
                Name=name, 
                Email=email,
                PhoneNumber=phone
            };

            users.Add(newuser);

            Console.WriteLine("===================User Information you Entered=================");
            Console.WriteLine($"name: {newuser.Name}");
            Console.WriteLine($"Email: {newuser.Email}");
            Console.WriteLine($"Phonenumber: {newuser.PhoneNumber}");
            Console.WriteLine("===============================================");
        }

        //Update User
        public void UpdateUser(List<User> users)
        {
            Console.Write("Enter User Phone you want to Edit: ");
            string phonenumber = Console.ReadLine();
            User founduser = users.FirstOrDefault(x => x.PhoneNumber == phonenumber);
            if (founduser != null)
            {
                Console.WriteLine("1-Edit Name: ");
                Console.WriteLine("2-Edit Email: ");
                Console.WriteLine("3-Edit PhoneNumber: ");

                int choose = int.Parse(Console.ReadLine());


                if (choose == 1)
                {
                    Console.Write("Enter Edited Name: ");
                    string name = Console.ReadLine();
                    founduser.Name = name;
                }

                else if (choose == 2)
                {
                    Console.Write("Enter Edited Email: ");
                    string email = Console.ReadLine();
                    founduser.Email = email;
                }

                else if (choose == 3)
                {
                    Console.Write("Enter Edited Phonenumber: ");
                    string phone = Console.ReadLine();
                    founduser.PhoneNumber = phone;
                }
                else
                {
                    Console.WriteLine("Wrong PhoneNumber");
                }

                Console.WriteLine("======================New User Information You Edited================ ");
                Console.WriteLine($"Name: {founduser.Name}");
                Console.WriteLine($"Email: {founduser.Email}");
                Console.WriteLine($"Phone: {founduser.PhoneNumber}");



            }
            else
            {
                Console.WriteLine("user Not Exist..Please Enter Correct User");
            }
            



        }

        
        //Print All User
        public void PrintAllUser(List<User> users)
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No User Exist To print");
            }
            int count = 1;
            foreach(var item in users)
            {
                Console.WriteLine($"User{count} is");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"PhoneNumber: {item.PhoneNumber}");
                Console.WriteLine("********************************");
                count++;
            }
        }
        public void DeleteUser(List<User> users)
        {
            

            Console.Write("Enter User Phone you want to Delete: ");
            string phonenumber = Console.ReadLine();
            User founduser = users.FirstOrDefault(x => x.PhoneNumber == phonenumber);
            if(founduser != null)
            {
                users.Remove(founduser);
                Console.WriteLine("Ok User is deleted");
            }
            else
            {
                Console.WriteLine("No User Like This");
            }
            
            
        }

    }
}

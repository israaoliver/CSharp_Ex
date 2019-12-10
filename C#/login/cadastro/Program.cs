using System;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            string login,password;


            Console.WriteLine("Login");
            login = Console.ReadLine();

            Console.WriteLine("Password");
            password = Console.ReadLine();
            
            if((login == "admin") && (password == "admin")){
                Console.WriteLine("Bem vindo admin!!");
            } else{
                Console.WriteLine("Você não é adm.");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Configuration Management Database******");

            while(true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add a Server");
                Console.WriteLine("2. Modify a Server property");
                Console.WriteLine("3. Delete a Server");
                Console.WriteLine("4. List all Servers");
                Console.Write("Select a choice from the above :- ");
                var choice = Console.ReadLine();


                switch (choice)
                    {
                    case "0":
                        return;
                    case "1":
                        Console.Write("Server Name :");
                        var servername = Console.ReadLine();
                        Console.Write("Service Name :");
                        var servicename = Console.ReadLine();
                        Console.Write("Forest Name :");
                        var forestname = Console.ReadLine();
                        Console.Write("Is Active: ");
                        var isactive = Convert.ToInt16(Console.ReadLine());

                        var serverinfo = cmdb.AddServer(servername, servicename, forestname, isactive);
                        Console.WriteLine($"Server Id: {serverinfo.ServerId}, Server Name: {serverinfo.ServerName},Service Name: {serverinfo.ServiceName}, Forest Name: {serverinfo.ForestName}, Is Active: {serverinfo.IsActive} ");

                        break;
                    case "2:":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }



            }

        }
    }
}

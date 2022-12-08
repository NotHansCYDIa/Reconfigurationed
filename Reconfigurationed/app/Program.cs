using System;

namespace app
{
    class Program
    {

        

        static void local(bool resDataImported)
        {
            Console.Write("Reconfigurationed@data:local ~ % ");
            var bash = Console.ReadLine();
            var resDataImported2 = false;
            var resToggled = true;

            if (bash == "") {
                local(resDataImported: resDataImported2);
            } else if (bash!.Contains("import ")) {
                if (bash!.Contains("resData")) {
                    if (resDataImported == false) {
                        Console.WriteLine("\n");
                        Console.WriteLine("                                           ");
                        Console.WriteLine("            IMPORT DATA SYSTEM             ");
                        Console.WriteLine(" ----------------------------------------- ");
                        Console.WriteLine(" NAME: resData       |       COMPATIBLE: Y ");
                        Console.WriteLine(" VERSION: 1.0        |      SYNC: c:import ");
                        Console.WriteLine(" ----------------------------------------- ");
                        Console.WriteLine("                                           ");
                        Console.WriteLine("   Would you like to import this Package?  ");
                        Console.Write("   Y/Yes N/No: ");
                        var s = Console.ReadLine();

                        if (s == "Y") {
                            Console.WriteLine("Importing data...");
                            Console.WriteLine("[-1---]");
                            Thread.Sleep(300);
                            Console.WriteLine("[-12--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-35--]");
                            Thread.Sleep(400);
                            Console.WriteLine("[-56--]");
                            Thread.Sleep(300);
                            Console.WriteLine("[-76--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-86--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-87--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-88--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-89--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-90--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-91--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-92--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-93--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-98--]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-100-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-112-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-123-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-134-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-145-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-156-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-167-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-178-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-189-]");
                            Thread.Sleep(100);
                            Console.WriteLine("[-200-]");
                            Thread.Sleep(100);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[*]: resData has been installed!");
                        
                            Console.ForegroundColor = ConsoleColor.White;


                            local(resDataImported: resDataImported2);
                            resDataImported = true;
                            resToggled = true;
                        }
                    }
                }
            } else if (bash == "clear") {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            
                local(resDataImported: resDataImported2);

            } else if (bash == "reset") {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                
                local(resDataImported: resDataImported2);
                resDataImported = false;
            } else if (bash!.Contains("echo -e")) {
                var echo = Console.ReadLine();
                Console.WriteLine(echo);
                local(resDataImported: resDataImported2);
            } else if (bash!.Contains("echo -config ")) {
                if (bash!.Contains("--res")) {
                    if (resDataImported == false) {
                        Console.WriteLine("[*]: --res extension unknown");
                        local(resDataImported: resDataImported2);
                    } else if (resDataImported == true) {
                        if (resToggled == true) {
                            Console.WriteLine("[*]: changed: res into OFF");
                            local(resDataImported: resDataImported2);
                            resToggled = false;
                        } else if (resToggled == false) {
                            Console.WriteLine("[*]: changed: res into ON");
                            local(resDataImported: resDataImported2);
                            resToggled = true;
                        }
                    }
                }

            } else {
                Console.WriteLine("[*]: command: "+ bash + " is not a command");
                local(resDataImported: resDataImported2);

            }


        }



        
        static void Main(string[] args)
        {
            Console.Title = "Reconfigurationed";
            Console.ForegroundColor = ConsoleColor.White;

            // Start

            

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            

            local(resDataImported: false);
        

                





        }
    }
}
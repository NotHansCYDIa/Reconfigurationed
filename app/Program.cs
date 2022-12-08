using System;

namespace app
{
    class Program
    {

        

        static void local(bool resDataImported, bool resToggled)
        {
            Console.Write("Reconfigurationed@data:local ~ % ");
            var bash = Console.ReadLine();
            
            bool resDataImported2 = resDataImported;
            var resToggled2 = resToggled;

            if (bash == "") {
                local(resDataImported: resDataImported2, resToggled: resToggled2);
            } else if (bash!.Contains("import ")) {
                if (bash!.Contains("resData")) {
                    if (resDataImported2 == false) {
                        Console.WriteLine("\n");
                        Console.WriteLine("                                           ");
                        Console.WriteLine("            IMPORT DATA SYSTEM             ");
                        Console.WriteLine(" ----------------------------------------- ");
                        Console.WriteLine(" NAME: resData       |       COMPATIBLE: Y ");
                        Console.WriteLine(" VERSION: 1.0        |        TYPE: Module ");
                        Console.WriteLine(" ----------------------------------------- ");
                        Console.WriteLine("                                           ");
                        Console.WriteLine("   Would you like to import this Package?  ");
                        Console.Write("   Y/Yes N/No: ");
                        var s = Console.ReadLine();

                        if (s == "Y") {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Importing data...");
                            Thread.Sleep(800);
                            Console.WriteLine("Getting module...");
                            Thread.Sleep(100);
                            Console.WriteLine("Getting receipt module...");
                            Thread.Sleep(400);
                            Console.WriteLine("Configurating receipt...");
                            Thread.Sleep(300);
                            Console.WriteLine("Generating author receipt ID...");
                            Thread.Sleep(200);
                            Console.WriteLine("Reloading...");
                            Thread.Sleep(100);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[*]: resData has been installed!");
                        
                            Console.ForegroundColor = ConsoleColor.White;

                            
                            resDataImported2 = true;
                            resToggled2 = true;
                            local(resDataImported: resDataImported2, resToggled: resToggled2);
                        } else {
                            local(resDataImported: resDataImported2, resToggled: resDataImported2);

                        }
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[*]: resData has been already installed");
                        Console.ForegroundColor = ConsoleColor.White;
                        local(resDataImported: resDataImported2, resToggled: resDataImported2);

                    }
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[*]: Module/Package was not found");
                    Console.ForegroundColor = ConsoleColor.White;
                    local(resDataImported: resDataImported2, resToggled: resDataImported2);

                }
            } else if (bash == "clear") {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            
                local(resDataImported: resDataImported2, resToggled: resToggled2);

            } else if (bash == "reset") {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                
                local(resDataImported: resDataImported2, resToggled: resToggled2);
                resDataImported = false;
            } else if (bash!.Contains("echo -e")) {
                var echo = Console.ReadLine();
                if (resToggled2) {
                    Console.WriteLine(echo);
                } else if (resToggled2 == false) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[*]: Unable to echo: " + echo + " due to permission to send resData has been revoked.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                local(resDataImported: resDataImported2, resToggled: resToggled2);
            } else if (bash!.Contains("echo -config ")) {
                if (bash!.Contains("--res")) {
                    if (resDataImported == false) {
                        Console.WriteLine("[*]: --res extension unknown");
                        local(resDataImported: resDataImported2, resToggled: resToggled2);
                    } else if (resDataImported == true) {
                        if (resToggled2 == true) {
                            Console.WriteLine("[*]: changed: res into OFF");
                            resToggled2 = false;
                            local(resDataImported: resDataImported2, resToggled: resToggled2);
                        } else if (resToggled2 == false) {
                            Console.WriteLine("[*]: changed: res into ON");
                            resToggled2 = true;
                            local(resDataImported: resDataImported2, resToggled: resToggled2);
                        }
                    }
                }

            } else if (bash!.Contains("cii ")) {
                if (bash!.Contains("resData")) {
                    if (resDataImported2 == true) {
                        Console.WriteLine("[*]: resData is imported");
                        local(resDataImported: resDataImported2, resToggled: resToggled2);
                        
                    } else if (resDataImported2 == false) {
                        Console.WriteLine("[*]: resData is not imported");
                        local(resDataImported: resDataImported2, resToggled: resToggled2);

                    }
                }
            } else {
                Console.WriteLine("[*]: command: "+ bash + " is not a command");
                local(resDataImported: resDataImported2, resToggled: resToggled2);

            }


        }



        
        static void Main(string[] args)
        {
            Console.Title = "Reconfigurationed";
            Console.ForegroundColor = ConsoleColor.White;

            // Start

            

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            

            local(resDataImported: false, resToggled: true);
        

                





        }
    }
}
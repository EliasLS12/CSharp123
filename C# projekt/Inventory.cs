using System;




    class Inventory
    {
            
        public void inventory(Programet _program, string _valg)
        {
            switch (_valg)
            {
                case "List":
                    for(int i = 1; i < 13; i++)
                    {
                        
                        Console.WriteLine(_program.getcar(i).completeCarspec());
                    }
                    break;
                default:
                    Console.WriteLine("Input not recognised");
                    break;
                
            }
       
        }
    }

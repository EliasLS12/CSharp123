﻿using System;
    
    public class Programet
    {
        Car Car00 = new Car();
        Car Car01 = new Car();
        Car Car02 = new Car();
        Car Car03 = new Car();
        Car Car04 = new Car();
        Car Car05 = new Car();
        Car Car06 = new Car();
        Car Car07 = new Car();
        Car Car08 = new Car();
        Car Car09 = new Car();
        Car Car10 = new Car();
        Car Car11 = new Car();
        Car Car12 = new Car();
        Car Car13 = new Car();
        int walletsize;
        person Buyerperson = new person();
        int[] mycars = new int[100];
         
        static void Main()
        {
            Programet program = new Programet();
            program.StartConsole();
        }
        public void StartConsole()
        {
            Console.WriteLine(mycars.Length);

            this.StartInventory();
            
            Console.WriteLine("Welcome to Joes car dealship.");
            Console.WriteLine("What is your name?");
            /*Inventory inventory = new Inventory();
            inventory.inventory("List");*/
            string PersonName = Console.ReadLine();
            Console.WriteLine("Are you looking to sell or buy a car",PersonName, "?[Sell,Buy,MyWallet,MyCar]");

        }
        public void StartInventory()
        {
            Car00.CarSpecs("","","","",0);
            Car01.CarSpecs("peugeot", "108", "0-100 km/h 14.3sec", "Doors 4",  99990  );
            Car02.CarSpecs("Peugeot", "206", "0-100 km/h 10.6sec", "Doors 4", 265539  ); 
            Car03.CarSpecs("Peugeot", "5008", "0-100 km/h 12.2sec", "Doors 4",  319990  ); 
            Car04.CarSpecs("Volkswagen", "Up", "0-100 km/h 14.4sec", "Doors 4" , 89996  ); 
            Car05.CarSpecs("Volkswagen", "Polo", "0-100 km/h 9.5sec", "Doors 4",  216021  ); 
            Car06.CarSpecs("Volkswagen", "Golf", "0-100 km/h 9.3sec", "Doors 4",  309997  ); 
            Car07.CarSpecs("Hyundai", "I10", "0-100 km/h 14.9 sec", "Doors 4",  119997  ); 
            Car08.CarSpecs("Hyundai", "I20", "0-100 km/h 10.4 sec", "Doors 4",  175816  ); 
            Car09.CarSpecs("Hyundai", "I30", "0-100 km/h 11.4 sec","Doors 4",  245913  ); 
            Car10.CarSpecs("Citroën", "C1", "0-100 km/h 11 sec","Doors 4",  90000  ); 
            Car11.CarSpecs("Citroën", "C3", "0-100 km/h 9,3 sec", "Doors 4",  275000  ); 
            Car12.CarSpecs("Citroën", "C4", "0-100 km/h 11,2 sec", "Doors 4",  250000  ); 
            walletsize = Buyerperson.MyWallet();
            mycars[0] = Buyerperson.MyCar();
        }
        public int[] getcar()
        {
            return mycars;
        }
        public int getwallet()
        {
            return walletsize;
        }
        public Car getcar(int _BilNumber)
        {
            switch(_BilNumber)
            {
                case 0:
                    return Car00;
                case 1:
                    return Car01;
                case 2:
                    return Car02;
                case 3:
                    return Car03;
                case 4:
                    return Car04;
                case 5:
                    return Car05;
                case 6:
                    return Car06;
                case 7:
                    return Car07;
                case 8:
                    return Car08;
                case 9:
                    return Car09;
                case 10:
                    return Car10;
                case 11:
                    return Car11;
                case 12:
                    return Car12;
                    default:
                    return Car01;
                    
                    
            }
        }

    }
   
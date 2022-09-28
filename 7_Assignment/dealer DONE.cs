using System; 
 
public class Dealer 
{ 
    public List<Car> AvaileableCars = new List<Car>(); 
    
    //public List<string> AvaileableCars = new List<string>(); 
    
    public List<Car> DealerCars() 
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
        
        Car00.CarSpecs("", "", "", "", 0); 
        Car01.CarSpecs("Peugeot", "108", "0-100 km/h 14.3sec", "Doors 4", 99990); 
        Car02.CarSpecs("Peugeot", "206", "0-100 km/h 10.6sec", "Doors 4", 265539); 
        Car03.CarSpecs("Peugeot", "5008", "0-100 km/h 12.2sec", "Doors 4", 319990); 
        Car04.CarSpecs("Volkswagen", "Up", "0-100 km/h 14.4sec", "Doors 4", 89996); 
        Car05.CarSpecs("Volkswagen", "Polo", "0-100 km/h 9.5sec", "Doors 4", 216021); 
        Car06.CarSpecs("Volkswagen", "Golf", "0-100 km/h 9.3sec", "Doors 4", 309997); 
        Car07.CarSpecs("Hyundai", "I10", "0-100 km/h 14.9 sec", "Doors 4", 119997); 
        Car08.CarSpecs("Hyundai", "I20", "0-100 km/h 10.4 sec", "Doors 4", 175816); 
        Car09.CarSpecs("Hyundai", "I30", "0-100 km/h 11.4 sec", "Doors 4", 245913); 
        Car10.CarSpecs("Citroën", "C1", "0-100 km/h 11 sec", "Doors 4", 90000); 
        Car11.CarSpecs("Citroën", "C3", "0-100 km/h 9,3 sec", "Doors 4", 275000); 
        Car12.CarSpecs("Citroën", "C4", "0-100 km/h 11,2 sec", "Doors 4", 250000); 
        AvaileableCars.Add(Car01);
        AvaileableCars.Add(Car02);
        AvaileableCars.Add(Car03);
        AvaileableCars.Add(Car04);
        AvaileableCars.Add(Car05);
        AvaileableCars.Add(Car06);
        AvaileableCars.Add(Car07);
        AvaileableCars.Add(Car08);
        AvaileableCars.Add(Car09);
        AvaileableCars.Add(Car10);
        AvaileableCars.Add(Car11);
        AvaileableCars.Add(Car12);
        return AvaileableCars;
        

        
        

 
    } 
    public void dealership(Programet _program, string _valg,int _walletsize, List<Car> _myCars)
    {
        switch (_valg)
        {
            case "Sell":
                Console.WriteLine("what car would you like to sell? [1, 2, 3...]");
                for(int i = 0; i < _myCars.Count; i++)
                {
                    Console.WriteLine(i+1 + " " + _myCars[i].completeCarspec());
                }
                int Sellkey = int.Parse(Console.ReadLine());
                Car CarSell =  _myCars[Sellkey - 1];
                _program.setwallet( _walletsize + CarSell.getprice());
                _myCars.Remove(_myCars[Sellkey - 1]);
                _program.setcar(_myCars);
                Console.WriteLine("new wallet size " + _program.getwallet() + " kr");
                break;

            case "Buy":
                if(AvaileableCars.Count == 0)
                {
                    this.DealerCars();
                }
                Console.WriteLine("What car would yo like to buy?");
                for(int i = 0; i < AvaileableCars.Count; i++)
                {
                    Console.WriteLine(i+1 + " " + AvaileableCars[i].completeCarspec());
                }
                int Buykey = int.Parse(Console.ReadLine());
                Car CarBuy =  AvaileableCars[Buykey - 1];
                if(_walletsize >= CarBuy.getprice())
                {
                    _program.setwallet( _walletsize - CarBuy.getprice());
                    _myCars.Add(CarBuy);
                    _program.setcar(_myCars);
                    Console.WriteLine("new wallet size " + _program.getwallet() + "kr");
                }
                else
                {
                    Console.WriteLine("You dont have enough money for this car");
                }
                break;
                default:
                break;
            
        }
    }

    
} 

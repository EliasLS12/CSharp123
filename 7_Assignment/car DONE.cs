using System; 
 
public class Car 
{ 
    public string Carbrand; 
    public string Model; 
    public string Acceleration; 
    public string Doors; 
    public int price; 
 
    public void CarSpecs(string _Carbrand, string _Model, string _Acceleration, string _Doors, int _Price) 
    { 
        Carbrand = _Carbrand; 
        Model = _Model; 
        Acceleration = _Acceleration; 
        Doors = _Doors; 
        price = _Price; 
 
    } 
 
    public string getCarbrand() 
    { 
        return Carbrand; 
    } 
    public string getModel() 
    { 
        return Model; 
    } 
    public string getAcceleration() 
    { 
        return Acceleration; 
    } 
    public string getDoors() 
    { 
        return Doors; 
    } 
    public string gettekstprice() 
    { 
        return "Price " + this.getprice() + " kr"; 
    } 
    public int getprice() 
    { 
        return price; 
    } 
    public string completeCarspec() 
    { 
        return Carbrand + ", " + Model + ", " + Acceleration + ", " + Doors + ", " + this.gettekstprice(); 
    } 
 
} 
 

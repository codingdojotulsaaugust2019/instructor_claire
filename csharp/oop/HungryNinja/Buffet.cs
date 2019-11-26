using System;
using System.Collections.Generic;

namespace HungryNinja
{
class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false)
        };
    }
     
    public Food Serve()
    {
        // return a Food item randomly selected from Menu list
    }
}
}
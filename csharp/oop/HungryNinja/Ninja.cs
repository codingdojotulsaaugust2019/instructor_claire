using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public bool IsFull{
            get 
            { 
                // if calorieIntake is greater than 1200
                // return true
                // else
                // return false
            }
        }
        
        // add a constructor
        
        // add a public "getter" property called "IsFull"
        
        // build out the Eat method
        public void Eat(Food item)
        {
            // if IsFull is false
            // then add the food item from the Serve method to foodhistory list
            // increase the ninja's calorieIntake property
        }
    }
}
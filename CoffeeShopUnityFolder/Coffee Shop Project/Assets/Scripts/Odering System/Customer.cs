using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
  //variables
  public static string drinkType = "Coffee";
  //This is a new keyword for us
  //Static means that Its per class, and not per instance of a class

  public UnityEvent raiseOrder;
  
  void Start()
  {
    RequestDrink(drinkType);
  }
  public void RequestDrink(string drinkType)
  {
    Debug.Log(drinkType);

  }
}


























//string[] coffeeTypes = { "Latte", "Cappuccino", "Espresso", "Americano", "Mocha" };
//string[] coffeeSizes = { "Small", "Medium", "Large" };
//int randomnumber = Random.Range(0, coffeeTypes.Length);
//int randomSize = Random.Range(0, coffeeSizes.Length);
//Debug.Log("I would like a " + coffeeSizes[randomSize] + " " + coffeeTypes[randomnumber]);

//public int randomnumber = 0;
//public int coffeesSold = 0;
//public float coffeePrice = 3.50f;
//public int amountOrdered = 5;
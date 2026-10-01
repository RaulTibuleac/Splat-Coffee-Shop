using UnityEngine;
using UnityEngine.Events;

public class CustomerOrder : MonoBehaviour
{
    //This will generate a random order for the customer
    public int randomNumber = 0;
    public int coffeesSold = 0;
    public float coffeePrice = 3.50f;

    public int amountOrdered = 5;

    void Start()
    {
        customer();
    }

    public void customer()
    {
        //The customer will order a ranfom coffee type and sizze
        string[] coffeeTypes = { "Latte", "Cappuccino", "Espresso", "Americano", "Mocha" };
        string[] coffeeSizes = { "Small", "Medium", "Large" };
        randomNumber = Random.Range(0, coffeeTypes.Length);
        int randomSize = Random.Range(0, coffeeSizes.Length);
        Debug.Log("I would like a " + coffeeSizes[randomSize] + " " + coffeeTypes[randomNumber]);

  }
}


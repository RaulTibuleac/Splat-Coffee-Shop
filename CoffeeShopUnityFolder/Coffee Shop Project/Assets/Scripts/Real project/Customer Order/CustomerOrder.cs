using UnityEngine;
using UnityEngine.Events;

public class CustomerOrder : MonoBehaviour
{
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
        string[] coffeeTypes = { "Latte", "Cappuccino", "Espresso", "Americano", "Mocha" };
        string[] coffeeSizes = { "Small", "Medium", "Large" };
        randomNumber = Random.Range(0, coffeeTypes.Length);
        int randomSize = Random.Range(0, coffeeSizes.Length);
        Debug.Log("I would like a " + coffeeSizes[randomSize] + " " + coffeeTypes[randomNumber]);

  }
}


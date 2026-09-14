using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int randomnumber = 0;
    public int coffeesSold = 0;
    public float coffeePrice = 3.50f;

    public int amountOrdered = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        customer();
    }
    // Update is called once per frame

    void customer()
    {
        string[] coffeeTypes = { "Latte", "Cappuccino", "Espresso", "Americano", "Mocha" };
        string[] coffeeSizes = { "Small", "Medium", "Large" };
        int randomnumber = Random.Range(0, coffeeTypes.Length);
        int randomSize = Random.Range(0, coffeeSizes.Length);
        Debug.Log("I would like a " + coffeeSizes[randomSize] + " " + coffeeTypes[randomnumber]);
        
    
    }
}

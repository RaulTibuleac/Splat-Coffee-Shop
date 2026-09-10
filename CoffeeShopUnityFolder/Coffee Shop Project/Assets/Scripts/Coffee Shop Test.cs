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
        Debug.Log("I have ordered");
        Debug.Log(amountOrdered + "coffees");
        amountOrdered++;
        Debug.Log("Cofees Sold: " + coffeesSold);
        customer();
    }
    // Update is called once per frame
    void AddCoffee()
    {
        coffeesSold++;
    }
    
    void customer()
    {
        string[] coffeeTypes = { "Latte", "Cappuccino", "Espresso", "Americano", "Mocha" };
        int randomnumber = Random.Range(0, coffeeTypes.Length);
        Debug.Log("I would like a " + coffeeTypes[randomnumber]);
        
    
    }
}

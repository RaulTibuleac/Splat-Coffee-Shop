using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CustomerOrder : MonoBehaviour

{
    //Public Integers
    public int itemsRequired;
    public int itemsGiven;
    public int price;

    //Refrences
    public ShiftOrder shiftOrder;
    public TillManager tillManager;

    void Start()
    {
        // Nothing happens when the game starts.
    }

    public void NewOrder()
    {
        itemsGiven = 0;

        itemsRequired = Random.Range(1, 3);

        if (itemsRequired == 1)
        {
            if (Random.value > 0.5f)
            {
                Debug.Log("Customer says: I want a coffee!");
                price = 3;
            }
            else
            {
                Debug.Log("Customer says: I want a donut!");
                price = 2;
            }
        }
        else
        {
            Debug.Log("Customer says: I want a coffee and a donut!");
            price = 5;
        }
    }

    public void GiveItem()
    {
        itemsGiven++;

        Debug.Log("GAVE ITEM: " + itemsGiven + "/" + itemsRequired);

        if (itemsGiven >= itemsRequired)
        {
            Debug.Log("ORDER COMPLETED!");

            shiftOrder.GiveItems();


            tillManager.ChoosePayment();
            tillManager.Pay(price);

            shiftOrder.CompleteOrder();

            if (shiftOrder.shiftsRemaining > 0)
            {
                NewOrder();
            }
        }
    }
}




// //public integers
// public int randomNumber = 0;
// public int coffeesSold = 0;
// public int amountOrdered = 5;


// [SerializeField] public float coffeePrice = 3.50f;

//     //calls customer
//     void Start()
//     {
//         //money();
//         customer();
//     }

//     public void customer()
//     {
//         //The customer will order a coffee and donut
//         string[] coffeeType = { "Coffee" };
//         string[] donutType = { "Dount"};

//         randomNumber = Random.Range(0, coffeeType.Length);
//         int donutNumber = Random.Range(0, donutType.Length);

//         Debug.Log("Hello, I would like to request a " + coffeeType[randomNumber] + " and a " + donutType[donutNumber]);
//     }

//     // private void money()
//     // {
//     //     //Coroutine that waits for 2 seconds so that the cashier can toatl everything up
//     //     StartCoroutine(processTime());
//     // }

//     // private IEnumerator processTime()
//     // {
//     //     yield return new WaitForSeconds(seconds);
//     //     Debug.Log("Your total for today is " + coffeePrice);
//     // }
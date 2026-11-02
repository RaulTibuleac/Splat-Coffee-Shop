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
    //Random pick between the items
    public void NewOrder()
    {
        itemsGiven = 0;

        itemsRequired = Random.Range(1, 3);

        if (itemsRequired == 1)
        {
            int randomItem = Random.Range(0, 2);

            if (randomItem == 0)
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
        //Adds an item to customer
        itemsGiven++;

        //outputs that I gave it to customer
        Debug.Log("GAVE ITEM: " + itemsGiven + "/" + itemsRequired);

        //If the items given is greater or equal to
        if (itemsGiven >= itemsRequired)
        {
            Debug.Log("ORDER COMPLETED!");

            //Refrence from till manager
            //Refrence from shift order 
            shiftOrder.GiveItems();

            //In the script tillmanager
            tillManager.ChoosePayment();
            tillManager.Pay(price);

            shiftOrder.CompleteOrder();

            //Calling the method NewOrder
            if (shiftOrder.shiftsRemaining > 0)
            {
                NewOrder();
            }
        }
    }
}

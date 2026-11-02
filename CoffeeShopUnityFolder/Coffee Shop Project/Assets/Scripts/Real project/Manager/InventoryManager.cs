using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //Public static boolean
    public static bool hasItem = false;

    //Public static string
    public static string heldItem = "";

    //Refrences to ther scripts
    public ShiftOrder shiftOrder;
    public CustomerOrder customerOrder;
    
    // If donut Picked Up
    public void d_item()
    {
        //If its empty
        if (heldItem == "")
        {
            //Inv no longer empty
            heldItem = "Donut";
            Debug.Log("You picked up the donut!");
        }
        else
        {
            //If tried to pick up again
            Debug.Log("You can only carry one item!");
        }
    }

    //If Coffee Picked up
    public void c_item()
    {
        if (heldItem == "")
        {
            //Inv no longer empty
            heldItem = "Coffee";
            Debug.Log("You picked up the coffee!");
        }
        else
        {
            //If tried to pick up again
            Debug.Log("You can only carry one item!");
        }
    }

    //If an Item Is Given To The Customer
    //If item held is not empty
    public void Customer()
    {
        if (heldItem != "")
        {
            //The item is empmty not in inv
            Debug.Log("You gave the customer: " + heldItem);

            customerOrder.GiveItem();

            heldItem = "";
        }
        else
        {
            //If empty then pick something up
            Debug.Log("You don't have an item to give!");
        }
    }
}

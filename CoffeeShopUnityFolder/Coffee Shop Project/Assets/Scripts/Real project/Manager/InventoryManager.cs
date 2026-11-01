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
        if (heldItem == "")
        {
            heldItem = "Donut";
            Debug.Log("You picked up the donut!");
        }
        else
        {
            Debug.Log("You can only carry one item!");
        }
    }

    //If Coffee Picked up
    public void c_item()
    {
        if (heldItem == "")
        {
            heldItem = "Coffee";
            Debug.Log("You picked up the coffee!");
        }
        else
        {
            Debug.Log("You can only carry one item!");
        }
    }

    //If an Item Is Given To The Customer
    public void Customer()
    {
        if (heldItem != "")
        {
            Debug.Log("You gave the customer: " + heldItem);

            customerOrder.GiveItem();

            heldItem = "";
        }
        else
        {
            Debug.Log("You don't have an item to give!");
        }
    }
}



//     public void d_item()
//     {
//         if (heldItem == "")
//         {
//             heldItem = "Donut";
//             Debug.Log("You picked up the donut!");
//         }
//         else
//         {
//             Debug.Log("You can only carry one item!");
//         }
//     }
//     //checks if the player has the item and gives it to the customer
//     public void c_item()
//     {
//         if (heldItem == "")
//         {
//             heldItem = "Coffee";
//             Debug.Log("You picked up the coffee!");
//         }
//         else
//         {
//             Debug.Log("You can only carry one item!");
//         }
//     }
//     //If the Item is in the inventory, it will be given to the customer and removed from the inventory

//   public void Customer()
//     {
//         if (hasItem)
//         {
//             hasItem = true;

//             shiftOrder.GiveItems();

//             Debug.Log("You gave an Item to the customer!");
//         }
//         else
//         {
//             Debug.Log("You don't have an item to give!");
//         }
//     }
// }
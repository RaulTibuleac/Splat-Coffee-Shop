using UnityEngine;

public class InventoryManager : MonoBehaviour
{
//Public static boolean
public static bool hasItem = false;
    public void d_item()
    {
        if (!GameManager.hasItem)
        {
            GameManager.hasItem = true;
            Debug.Log("You picked up the donut!");
        }
        else
        {
            Debug.Log("You can only carry one Item!");
        }
    }
    //checks if the player has the item and gives it to the customer
    public void c_item()
    {
        if (!GameManager.hasItem)
        {
            GameManager.hasItem = true;
            Debug.Log("You picked up the coffee!");
        }
        else
        {
            Debug.Log("You can only carry one Item!");
        }
    }
    //If the Item is in the inventory, it will be given to the customer and removed from the inventory
    public void Customer()
    {
        if (GameManager.hasItem)
        {
            GameManager.hasItem = false;
            Debug.Log("you gave an Item to the customer!");

        }
    
    }

}

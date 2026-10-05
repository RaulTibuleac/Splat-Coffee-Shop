using UnityEngine;

public class InventoryManager : MonoBehaviour
{
public void d_item()
{
    if (!GameManager.hasItem)
    {
        GameManager.hasItem = true;
        Debug.Log("You picked up the donut!");
    }
    else
    {
        Debug.Log("You can only carry one item!");
    }
}

public void c_item()
{
     if (!GameManager.hasItem)
     {
        GameManager.hasItem = true;
        Debug.Log("You picked up the coffee!");
     }
    else
    {
        Debug.Log("You can only carry one item!");
    }
}

void downgrade()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            c_item();
        }
    }
}

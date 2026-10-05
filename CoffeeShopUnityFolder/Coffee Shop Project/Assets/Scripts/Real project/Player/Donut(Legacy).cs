using UnityEngine;

public class Donut : MonoBehaviour
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

 void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            d_item();
            Debug.LogError("Both scripts output the same thing twice with 'E' and pressing 'E' picks up only the donut and not the coffee cannot pick which one you pick up!");
        }
    }
}

        
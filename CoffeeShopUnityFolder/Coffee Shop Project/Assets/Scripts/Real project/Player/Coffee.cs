using UnityEngine;

public class Coffee : MonoBehaviour
{
public void c_item()
{
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
}

void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            c_item();
        }
    }
}
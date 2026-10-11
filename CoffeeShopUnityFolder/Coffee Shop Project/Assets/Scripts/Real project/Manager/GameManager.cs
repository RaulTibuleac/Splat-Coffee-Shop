using UnityEngine;

public class GameManager : MonoBehaviour
{
//Public static boolean
public static bool hasItem = false;
public void Customer()
    {
        if (hasItem)
        {
            hasItem = true;
            Debug.Log("you picked up the item");
        }
        else if (hasItem)
        {
            hasItem = false;
            Debug.Log("you gave the item to them");
        }
    }
}


using UnityEngine;

public class GameManager : MonoBehaviour
{
//Public static boolean
public static bool hasItem = false;
   void Start()
    {
        //The player has no Item and If they pick the Item up
        //It will output they have picked the Item up
        if (hasItem)
        {
            hasItem = true;
            Debug.Log("You picked up the Item!");
        }
        //If the player has the Item outputs you gave them the Item
        else if (hasItem)
        {
        hasItem = false;
        Debug.Log("You gave the item to them!");
        }
   }
    
}


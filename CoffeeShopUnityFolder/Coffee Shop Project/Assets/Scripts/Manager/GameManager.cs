using UnityEngine;

public class GameManager : MonoBehaviour

{
public bool hasItem = false;
   void Start()
    {
        if (hasItem)
        {
            hasItem = true;
            Debug.Log("You picked up the item!");
        }
        else if (hasItem)
        {
        hasItem = false;
        Debug.Log("You gave the item to them!");
        }
   }
    
}


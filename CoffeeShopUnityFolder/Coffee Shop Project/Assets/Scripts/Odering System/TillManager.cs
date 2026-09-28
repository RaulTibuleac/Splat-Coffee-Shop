using UnityEngine;

public class TillManager : MonoBehaviour
{
    void Start()
    {
        Debug.LogError("No PlayerController found in parent!");
        processOrder();
    }
    void processOrder()
    {
        Debug.Log(Customer.drinkType);


    }

}
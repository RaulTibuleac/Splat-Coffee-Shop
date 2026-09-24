using UnityEngine;

public class TillManager : MonoBehaviour
{
    void Start()
    {
        processOrder();
    }
    void processOrder()
    {
        Debug.Log(Customer.drinkType);

    }

}
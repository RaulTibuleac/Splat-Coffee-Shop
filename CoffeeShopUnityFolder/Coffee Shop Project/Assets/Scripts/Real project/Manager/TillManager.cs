using UnityEngine;

public class CustomerPayment : MonoBehaviour
{
    public bool paysCash;

    void Start()
    {
        int randomNumber = Random.Range(0, 2);

        if (randomNumber == 0)
        {
            paysCash = true;
            Debug.Log("Customer will pay with cash");
        }
        else
        {
            paysCash = false;
            Debug.Log("Customer will pay with card");
        }
    }

    public void Pay()
    {
        if (paysCash)
        {
            Debug.Log("Customer paid with cash!");
        }
        else
        {
            Debug.Log("Customer paid with card!");
        }
    }
}
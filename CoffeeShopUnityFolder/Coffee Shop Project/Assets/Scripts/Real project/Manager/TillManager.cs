using UnityEngine;

public class TillManager : MonoBehaviour
{
    //Public Boolean
    private bool paysCash;

    //Random option for the payment type
    public void ChoosePayment()
    {
        int randomNumber = Random.Range(0, 2);

        if (randomNumber == 0)
        {
            paysCash = true;
        }
        else
        {
            paysCash = false;
        }
    }

    //method with a price
    
    public void Pay(int price)
    {
        if (paysCash)
        {
            Debug.Log("Customer paid with cash: £" + price);
        }
        else
        {
            Debug.Log("Customer paid with card: £" + price);
        }
    }
}
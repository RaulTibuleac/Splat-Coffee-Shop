using UnityEngine;

public class TillManager : MonoBehaviour
{
    //Public Boolean
    private bool paysCash;


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
using UnityEngine;

public class OrderingSystemProject : MonoBehaviour
{
    private float _costOfCoffee = 4;

    public int coffeeAmountOrdered;

    public float totalOrderAmount;
    
    public void AmountPlaced(int coffeeAmountOrdered)
    {
       totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
       Debug.Log("your total order amount is: " + totalOrderAmount);
    }
}
//Access modifiers
//void -> private void
//void
//public void -> public void



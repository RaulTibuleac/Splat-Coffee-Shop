using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
  //variables
  public static string drinkType = "Coffee";
  //This is a new keyword for us
  //Static means that Its per class, and not per instance of a class

  public UnityEvent raiseOrder;

  void Start()
  {
    RequestDrink(drinkType);
  }
  public void RequestDrink(string drinkType)
  {
    Debug.Log(drinkType);

  }
}

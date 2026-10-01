using UnityEngine;

public class CoffeeMachine : MonoBehaviour

{
bool coffeeMachineOn = true;
    public void Coffee()
    {
        if (!coffeeMachineOn)
        {
            Debug.Log("Brewing coffee");
        }
    else 
        {
            Debug.Log("Out of coffee beans");
        }
    }
}
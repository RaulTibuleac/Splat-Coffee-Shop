using UnityEngine;

public class EIRUGH : MonoBehaviour
{
private string[] coffeeMenu = {"Espresso", "Cappuccino", "Latte, Mocha", "Americano", "Macchiato"};
private int refills = 1;
private int maxRefills = 11;
void Start()
{
 {
        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("Now serving " + coffee);
        }
    }

    for (int i = 0; i < 10; i++)
    {
        Debug.Log("Coffee number:" + i);
    }

   

    do
    {
        Debug.Log("Serving coffee refill number: " + refills);
        refills++;
    }
    while (refills < maxRefills);

    









}
}
 



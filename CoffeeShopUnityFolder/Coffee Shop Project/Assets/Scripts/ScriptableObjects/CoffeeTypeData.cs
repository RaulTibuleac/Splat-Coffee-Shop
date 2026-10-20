using UnityEngine;

    public enum CoffeeType
        {
            Espresso,
            Latte,
            Cappuccino,
            Americano,
            None
        }

[CreateAssetMenu(fileName = "CoffeeTypeData", menuName = "Game/CoffeeTypeData")]
public class CoffeeData : ScriptableObject
{
    public float espressoPrice = 2.00f;
    public float lattePrice = 3.00f;
    public float cappuccinoPrice = 2.50f;
    public float americanoPrice = 3.50f;
}
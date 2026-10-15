using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeItems", menuName = "Game/Items")]
public class CoffeeItems : ScriptableObject
{
    CoffeeType type = CoffeeType.Espresso;
}

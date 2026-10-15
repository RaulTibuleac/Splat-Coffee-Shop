using UnityEngine;

public enum Allergies
{
    Milk,
    Gluten,
}

[CreateAssetMenu(fileName = "Ingredients", menuName = "Game/Ingredients")]
public class Ingredients : ScriptableObject
    {
    public float price;
    public int quantity;
    public bool inStock;
    public Allergies[] allergies;

    }


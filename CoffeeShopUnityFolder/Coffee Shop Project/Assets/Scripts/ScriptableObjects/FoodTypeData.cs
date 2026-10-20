using UnityEngine;

public enum FoodType
{
    Doughnut,
    Biscuit,
    Toast,
    None
}

[CreateAssetMenu(fileName = "FoodTypeData", menuName = "Game/FoodTypeData")]
public class FoodTypeData : ScriptableObject
{
    public float doughnutPrice = 2.00f;
    public float biscuitPrice = 1.00f;
    public float toastPrice = 1.50f;
}

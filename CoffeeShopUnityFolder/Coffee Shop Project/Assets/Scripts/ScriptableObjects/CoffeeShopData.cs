using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeShopData", menuName = "Game/CoffeeShopData")]
public class CoffeeData : ScriptableObject
{
    public CoffeeItems menu;
    public string CoffeName;
    public Sprite CoffeeIcon;
    public int value;

}
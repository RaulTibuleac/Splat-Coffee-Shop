// using UnityEngine;
// using System.Collections;
// using System.Collections.Generic;

// public class TestSwitch : MonoBehaviour
// {
//     public enum CoffeeType
//     {
//         Espresso,
//         Latte,
//         Cappuccino,
//         Nitro_Cold_Brew,
//         None
//     }
// [SerializeField] private CoffeeType coffeeOrder = CoffeeType.Latte;
//     void Start()
//     {
//         //Switch statement to handle different coffee orders
//         switch (coffeeOrder)
//         {
//         case CoffeeType.Espresso:
//             Debug.Log("Making a strong Espresso");
//             break;
//         case CoffeeType.Latte:
//             Debug.Log("Preparing a creamy Latte with steamed milk");
//             break;
//         case CoffeeType.Cappuccino:
//             Debug.Log("Pouring hot water into a rich Espresso for an Americano");
//             break;
//         default:
//             Debug.Log("Sorry, we don't have that drink on the menu");
//             break;

//         }
//     }
// }

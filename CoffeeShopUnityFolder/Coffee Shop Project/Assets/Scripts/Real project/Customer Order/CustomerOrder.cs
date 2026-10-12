using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CustomerOrder : MonoBehaviour
{

    //public integers
    public int randomNumber = 0;
    public int coffeesSold = 0;
    public int amountOrdered = 5;

    //Public float
    public float coffeePrice = 3.50f;

    //calls customer
    void Start()
    {
        customer();
    }

    public void customer()
    {
        //The customer will order a coffee and donut
        string[] coffeeType = { "Coffee" };
        string[] donutType = { "Dount"};

        randomNumber = Random.Range(0, coffeeType.Length);
        int donutNumber = Random.Range(0, donutType.Length);

        Debug.Log("Hello, I would like to request a " + coffeeType[randomNumber] + "and a " + donutType[donutNumber]);
  }
}

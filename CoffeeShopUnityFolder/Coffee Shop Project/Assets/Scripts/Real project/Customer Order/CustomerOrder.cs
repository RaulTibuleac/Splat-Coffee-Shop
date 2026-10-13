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
    public float seconds = 2;
     [SerializeField] public float coffeePrice = 3.50f;

    //calls customer
    void Start()
    {
        money();
        customer();
    }

    public void customer()
    {
        //The customer will order a coffee and donut
        string[] coffeeType = { "Coffee" };
        string[] donutType = { "Dount"};

        randomNumber = Random.Range(0, coffeeType.Length);
        int donutNumber = Random.Range(0, donutType.Length);

        Debug.Log("Hello, I would like to request a " + coffeeType[randomNumber] + " and a " + donutType[donutNumber]);
  }

    private void money()
    {
        //Coroutine that waits for 2 seconds so that the cashier can toatl everything up
        StartCoroutine(processTime());
    }

    private IEnumerator processTime()
    {
        yield return new WaitForSeconds(seconds);
        Debug.Log("Your total for today is " + coffeePrice);
    }

}

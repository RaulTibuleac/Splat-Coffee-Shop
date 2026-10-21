using UnityEngine;
public class ShiftOrder : MonoBehaviour
{
    //Public Integer
    public int shiftsRemaining = 3;
    //Public Boolean
    public bool dayStarted = false;
    
    public void ClockIn()
    {
        //If the player decides to click It again
        // It will say that the shifts already started
        if (dayStarted)
        {
        Debug.Log("Shift has already started!");
        }
        //If the player has not then It will start the game
        else if (dayStarted = true)
        {
        Debug.Log("Shift Started!");
        Debug.Log("The first shift has started!");
        }
    }

    public void CompleteOrder()
    {
        //If they player tries to play before clocking in then It will
        //say that they must clock In first
        if (!dayStarted)
        {
            Debug.Log("You must clock In first!");
        }
        //Shifts count down
        shiftsRemaining-- ;
        Debug.Log("Customer order completed!");
        Debug.Log("Shifts remaining: " + shiftsRemaining);

        //Once the shifts reaches 0 It will say
        //You can go home now 
        if (shiftsRemaining <= 0)
        {
            Debug.Log("Shifts Over, you can go home now!");
            dayStarted = false;
        }
        else
        {
            Debug.Log("Next shit has started!");
        }
    }
}
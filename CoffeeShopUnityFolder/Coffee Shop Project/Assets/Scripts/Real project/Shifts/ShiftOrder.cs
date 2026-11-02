using UnityEngine;
public class ShiftOrder : MonoBehaviour
{
    //Public Integer
    public int shiftsRemaining = 3;
    public int ordersCompleted = 0;

    //Public Boolean
    public bool dayStarted = false;
    public bool itemsGiven = false;

    //Refrence
    public CustomerOrder customerOrder;
    
    public void ClockIn()
    {
        // All shifts are finished
        if (shiftsRemaining <= 0)
        {
            Debug.Log("You can go home!");
            return;
        }

        // Shift is already running
        if (dayStarted)
        {
            Debug.Log("Shift has already started!");
            return;
        }

        // Start the shift
        dayStarted = true;

        Debug.Log("Shift Started!");

        customerOrder.NewOrder();
    }

    //If the person has not clocked In
    //They will need to clock In
    public void CompleteOrder()
    {
        if (!dayStarted)
        {
            Debug.Log("You must clock in first!");
            return;
        }

        if (!itemsGiven)
        {
            Debug.Log("You need to give the customer their items!");
            return;
        }

        itemsGiven = false;

        CompleteShift();
    }


    public void GiveItems()
    {
        itemsGiven = true;
        Debug.Log("Items given to customer!");
    }

    //Counts down the shifts
    //If the shifts is less than or equal to 0
    //It will output all shifts completed
    public void CompleteShift()
    {
        shiftsRemaining--;

        int completedShift = 3 - shiftsRemaining;

        Debug.Log("SHIFT " + completedShift + " COMPLETED!");
        Debug.Log("Shifts remaining: " + shiftsRemaining);

        if (shiftsRemaining <= 0)
        {
            Debug.Log("ALL SHIFTS COMPLETED!");

            dayStarted = false;
            return;
        }

        Debug.Log("Next shift started!");
    }
}
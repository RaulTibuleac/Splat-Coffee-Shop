using UnityEngine;
public class ShiftOrder : MonoBehaviour

{
//There will be 3 shifts in the game, this will count down the shifts and output how many are left
int shiftOrder = 3;
int items = 0;
    public void CorrectItem()
    {
        //If the player gives the correct item to the customer, it will count down the shifts and output how many are left
        items++;

        if (items == 3)
        {
         shiftOrder --;
         items++;
         Debug.Log("shift completed!");
         Debug.Log("shifts remaining: " +shiftOrder);
        }
        //When the shift order reaches 0, it will output that the shifts are over
        if (shiftOrder == 0)
        {
            Debug.Log("Shifts Over!");
        }

    }
}

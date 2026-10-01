using UnityEngine;
public class ShiftOrder : MonoBehaviour

{
    //There will be 3 shifts in the game, this will count down the shifts and output how many are left
    int shiftOrder = 3;
    public void Shifts()
    {
        //Count down the shifts and output how many are left
        shiftOrder --;
        if (shiftOrder >0)
        {
            //Outputs how many shifts are left
            Debug.Log("Shift's remaining: " + shiftOrder);
        }
       //Outputs that the shift is over
        else if (shiftOrder ==0)
        {
         Debug.Log("Shift's over!");
        }
    }
}

using UnityEngine;
public class ShiftOrder : MonoBehaviour

{
    int shiftOrder = 3;
    public void go()
    {
        shiftOrder --;
        if (shiftOrder >0)
        {
            Debug.Log("Shift's remaining: " + shiftOrder);
        }
       
        else if (shiftOrder ==0)
        {
         Debug.Log("Shift's over!");
        }
    }
}

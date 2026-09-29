using UnityEngine;
public class ShiftOrder : MonoBehaviour

{
    int shiftOrder = 3;
    public void go()
    {
        if (shiftOrder >0)
        {
            shiftOrder --;
            Debug.Log("Shift's remaining: " + shiftOrder);
        }
       
        else
        {
         Debug.Log("Shift's over!");
        }
    }
}

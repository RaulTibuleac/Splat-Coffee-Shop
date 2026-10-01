using UnityEngine;

public class Torch : MonoBehaviour
{
    //This will turn the torch on and off when the player presses the T key
    //Public boolean
    public bool isTorchOn = true;
    public void Fire()
    {
        //If the torch is on, It will output that the torch is on
        if (isTorchOn)
        {
            Debug.Log("Torch is on");
        }
    }
 public void Update()
    {
        //Player presses the T key to turn the torch on and off
        //If the torch is on, It will output that the torch is on, if the torch is off, It will then output that the torch Is off
        if (Input.GetKeyDown(KeyCode.T))
        {
            isTorchOn = !isTorchOn;
            if (isTorchOn)
            {
                Debug.Log("Torch is on");
            }
            else
            {
                Debug.Log("Torch is off");
            }
        }
    }

}
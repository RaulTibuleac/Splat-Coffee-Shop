//THIS IS SCRIPT A
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    //Every frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //This Is tagged "Main Camera" on the deafuult camera - only one camera should be the "Main Camera"
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();

                clickable?.OnClick();
                //calls the interface "IClickable"
            }
        }
    }
}

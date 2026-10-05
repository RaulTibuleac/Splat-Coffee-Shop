using UnityEngine;
using UnityEngine.Events;

public class ClickDetectorE : MonoBehaviour
{
    //Every frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //This Is tagged "Main Camera" on the deafuult camera - only one camera should be the "Main Camera"
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IClickableE clickable = hit.collider.GetComponent<IClickableE>();

                clickable?.OnClickE();
                //calls the interface "IClickableE"
            }
        }
    }
}

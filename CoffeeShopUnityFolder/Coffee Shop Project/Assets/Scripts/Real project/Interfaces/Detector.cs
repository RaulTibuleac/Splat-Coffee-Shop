using UnityEngine;

public class Detector : MonoBehaviour
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
                IIClickable clickable = hit.collider.GetComponent<IIClickable>();

                clickable?.OnClick();
                //calls the interface "IIClickable"
            }
        }
    }
}

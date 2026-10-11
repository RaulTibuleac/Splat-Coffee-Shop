using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] float _sensX;
    [SerializeField] float _sensY;

    private float rotationX;
    private float rotationY;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * _sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * _sensY;

        rotationY += mouseX;

        rotationX -= mouseY;  
        rotationX = Mathf.Clamp(rotationX, -67.5f, 67.5f); 
    }
    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}

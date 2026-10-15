using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField]public float speed = 5f;

    void Update()
    {
        float forward = Input.GetAxisRaw("Vertical");
        float sideways = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(sideways, 0, forward);

        // Move down with Space
        if (Input.GetKey(KeyCode.Space))
        {
            movement.y +=1;
        }

        transform.Translate(movement.normalized * speed * Time.deltaTime);
    }
}
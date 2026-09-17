using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    [SerializeField] private int CountClicks;

    private void OnMouseDown()
    {

        Debug.Log("Hello, Oscar");
        CountClicks++;
    }
}

//THIS IS SCRIPT B
using UnityEngine;
using UnityEngine.Events;

public class ClickableObjectE : MonoBehaviour, IClickableE
{
    [SerializeField] private UnityEvent onClickActionE;

    public void OnClickE()
    {
        onClickActionE?.Invoke();
    }
}
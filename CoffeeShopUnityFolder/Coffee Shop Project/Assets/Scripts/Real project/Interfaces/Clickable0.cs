using UnityEngine;
using UnityEngine.Events;

public class Clickable : MonoBehaviour, IIClickable
{
    [SerializeField] private UnityEvent onClickAction;

    public void OnClick()
    {
        onClickAction?.Invoke();
    }
}

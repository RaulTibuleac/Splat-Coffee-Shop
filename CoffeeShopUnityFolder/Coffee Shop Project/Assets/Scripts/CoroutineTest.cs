using UnityEngine;
using System.Collections;

public class CoroutineTest : MonoBehaviour
{
 public float seconds = 2;
   private void Start()
    {
        StartCoroutine(MakeCoffee());
    }

    private IEnumerator MakeCoffee()
    {
        yield return new WaitForSeconds(seconds);
        Debug.Log("Coffee Ready!");
    }
}

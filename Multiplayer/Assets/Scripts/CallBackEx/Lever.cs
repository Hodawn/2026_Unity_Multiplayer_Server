using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent OnPulled;
    private bool isUsed = false;

    private void Update()
    {
        if (isUsed) return;
        if(Input.GetKeyDown(KeyCode.E))
        {
            isUsed = true;
            Debug.Log("·¹¹ö ´ç±è");
            OnPulled.Invoke();
        }
    }
}

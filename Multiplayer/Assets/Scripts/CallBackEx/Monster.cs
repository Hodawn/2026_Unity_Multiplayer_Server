using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public IQuestCallbacks Callbacks;
    private bool isDead = false;

    private void Update()
    {
        if (isDead) return;
        
        if(Input.GetKeyDown(KeyCode.K))
            {
            isDead = true;
            Debug.Log("슬라임 컷");
            Callbacks?.OnMonsterKilled("슬라임");
            gameObject.SetActive(false);
            }
    }
}

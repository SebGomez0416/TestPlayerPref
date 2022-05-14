
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider o)
    {
        if (!o.CompareTag("Player")) return;
        PlayerPrefs.SetFloat( Move.position, o.transform.position.z);
        PlayerPrefs.Save();
    }

    
}

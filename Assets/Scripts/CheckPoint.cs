
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private float position;
    private void OnTriggerEnter(Collider o)
    {
        if (o.CompareTag("Player"))
        {
            PlayerPrefs.SetFloat("position", o.transform.position.z);
            PlayerPrefs.Save();
        }
    }

    
}

using UnityEngine;

public class SoundPref : MonoBehaviour
{
    [SerializeField]private AudioClip track;
    private void OnTriggerEnter(Collider o)
    {
        if (!o.CompareTag("Player")) return;
        o.GetComponent<AudioSource>().clip = track;
        o.GetComponent<AudioSource>().Play();
    }
}

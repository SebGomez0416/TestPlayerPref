using UnityEngine;

public class SoundPref : MonoBehaviour
{
    [SerializeField] private AudioController.MyTracks _myTrack;
    public delegate void SetTrack(AudioController.MyTracks t);
    public static SetTrack OnSetTrack;
    
    private void OnTriggerEnter(Collider o)
    {
        if (!o.CompareTag("Player")) return;
        OnSetTrack?.Invoke(_myTrack);
    }
}

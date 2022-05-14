
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
   [SerializeField] private Slider track_One;
   [SerializeField] private Slider track_Two;
   [SerializeField] private AudioSource _audioController;
   public const string volume_one = "volume_one";
   public const string volume_two = "volume_two";
   private int sliderActive;

   private void Awake()
   {
      track_One.value= PlayerPrefs.GetFloat(volume_one,1f);
      track_Two.value=PlayerPrefs.GetFloat(volume_two,1f);
   }

   private void OnEnable()
   {
       SoundPref.OnSetTrack +=SaveVolume;
   }

   private void OnDisable()
   {
       SoundPref.OnSetTrack -=SaveVolume;
   }

  public  void setVolume()
  {
      if (sliderActive+1 ==1)
          _audioController.volume = track_One.value;
      if (sliderActive+1 ==2)
          _audioController.volume = track_Two.value;
      }

  private void SaveVolume(AudioController.MyTracks t)
  {
      sliderActive = (int)t;
      switch (t)
      {
          case AudioController.MyTracks.One:
              PlayerPrefs.SetFloat( volume_one, track_One.value);
              PlayerPrefs.Save();
              break;
          case AudioController.MyTracks.Two:
              PlayerPrefs.SetFloat( volume_two, track_Two.value);
              PlayerPrefs.Save();
              break;
          
      }
  }
   
}

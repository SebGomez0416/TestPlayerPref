using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
   [SerializeField] private Slider track_One;
   [SerializeField] private Slider track_Two;
   [SerializeField] private AudioSource ac;


  public  void setVolume(int slider)
  {
      ac.volume = slider ==1 ? track_One.value : track_Two.value;
  }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioVolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }
    public void changeVolume()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
    void Update()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}
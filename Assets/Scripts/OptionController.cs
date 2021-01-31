using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    public float currentVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        currentVolume = 1f;
        if (PlayerPrefs.HasKey("volume_configured"))
        {
            currentVolume = PlayerPrefs.GetFloat("volume_configured");
        }

        GameObject slider = GameObject.Find("Slider");
        if (slider != null)
        {
            slider.GetComponent<Slider>().value = currentVolume;
        }
        else
        {
            Debug.Log("Not Found!!!");
        }
    }

    public void UpdateVolume()
    {
        GameObject slider = GameObject.Find("Slider");
        if (slider != null)
        {
            currentVolume = slider.GetComponent<Slider>().value;
            PlayerPrefs.SetFloat("volume_configured", currentVolume);
            GameObject sound = GameObject.Find("AudioOptions");
            if (sound != null)
            {
                sound.GetComponent<AudioSource>().volume = currentVolume;
            }
        }
        else
        {
            Debug.Log("Not Found!!!!");
        }
    }


}

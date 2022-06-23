using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Sprite vol;
    public Sprite noVol;

    void Update()
    { 
        if (PlayerPrefs.GetFloat("Volume") == 1f)
        {
            GetComponent<Button>().image.overrideSprite = vol;
        }
        else
        {
            GetComponent<Button>().image.overrideSprite = noVol;
        }
    }

    public void VolumeButton()
    {
        if (PlayerPrefs.GetFloat("Volume") == 1f)
        {
            PlayerPrefs.SetFloat("Volume", 0f);
        }
        else
        {
            PlayerPrefs.SetFloat("Volume", 1f);
        }

        Debug.Log(PlayerPrefs.GetFloat("Volume"));
    }
}

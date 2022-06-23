using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsBack : MonoBehaviour
{
    public GameObject panel;

    public void Back()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }
}

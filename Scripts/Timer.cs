using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerWidget;

    public float minuteTimer = 0f;
    public int hourTimer = 8;

    public int level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        minuteTimer += Time.fixedDeltaTime * 2.5f;
        if (Mathf.Round(minuteTimer) >= 60f)
        {
            hourTimer += 1;
            minuteTimer = minuteTimer - 60f;
        }
    }

    void Update()
    {
        string time = hourTimer.ToString() + ":" + Mathf.Round(minuteTimer).ToString();
        timerWidget.text = time;

        if (level == 1)
        {
            if (hourTimer >= 10)
                SceneManager.LoadScene("RestartScene");
        }
        else if (level == 2)
        {
            if (hourTimer >= 22)
            {
                SceneManager.LoadScene("RestartScene");
            }
        }
    }
}

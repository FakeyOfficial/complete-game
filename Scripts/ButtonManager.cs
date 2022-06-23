using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject fade;
    public Canvas canvas;

    public void PlayButton()
    {
        fade.GetComponent<GameManager>().name = "Level0";
        fade.GetComponent<Animator>().SetTrigger("fadeOut");
        canvas.gameObject.SetActive(false);
    }

    public void SettingsButton()
    {
        fade.GetComponent<GameManager>().name = "SettingsMenu";
        fade.GetComponent<Animator>().SetTrigger("fadeOut");
        canvas.gameObject.SetActive(false);
    }

    public void SettingsToMainMenu()
    {
        fade.GetComponent<GameManager>().name = "MainMenu";
        fade.GetComponent<Animator>().SetTrigger("fadeOut");
        canvas.gameObject.SetActive(false);
    }

    public void NextButton()
    {
        fade.GetComponent<GameManager>().name = "Level1";
        fade.GetComponent<Animator>().SetTrigger("fadeOut");
        canvas.gameObject.SetActive(false);
    }

    public void NextButton2()
    {
        fade.GetComponent<GameManager>().name = "Level2";
        fade.GetComponent<Animator>().SetTrigger("fadeOut");
        canvas.gameObject.SetActive(false);
    }

    public void AllLevels()
    {
        fade.GetComponent<GameManager>().name = "AllLevels";
        fade.GetComponent<Animator>().SetTrigger("fadeOut");
        canvas.gameObject.SetActive(false);
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void SeeWebsite()
    {
        Application.OpenURL("https://scottishwildlifetrust.org.uk/");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

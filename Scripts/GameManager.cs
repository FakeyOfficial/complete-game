using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string name = "Level1";

    public void LoadScene()
    {
        SceneManager.LoadScene(name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Player player;
    public GameObject canvas;

    void Start()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            player.runSpeed = 0f;
        }
        canvas.SetActive(false);
    }

    public void EndAnim()
    {
        if (player != null)
            player.runSpeed = 40f;
        canvas.SetActive(true);
        Destroy(gameObject);
    }
}

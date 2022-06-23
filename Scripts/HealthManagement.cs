using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagement : MonoBehaviour
{
    public Player player;
    public GameObject[] healthIcon;

    // Update is called once per frame
    void Update()
    {
        if (player.health == 3)
        {
            healthIcon[0].SetActive(true);
            healthIcon[1].SetActive(true);
            healthIcon[2].SetActive(true);
        }
        else if (player.health == 2)
        {
            healthIcon[0].SetActive(true);
            healthIcon[1].SetActive(true);
            healthIcon[2].SetActive(false);
        }
        else if (player.health == 1)
        {
            healthIcon[0].SetActive(true);
            healthIcon[1].SetActive(false);
            healthIcon[2].SetActive(false);
        }
    }
}

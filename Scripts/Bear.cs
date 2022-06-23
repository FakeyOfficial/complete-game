using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public Player player;

    bool isInRange = false;

    // Update is called once per frame
    public void CheckPlayer()
    {
        if (isInRange)
        {
            player.health--;
            Debug.Log("hit");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isInRange = false;
        }
    }
}

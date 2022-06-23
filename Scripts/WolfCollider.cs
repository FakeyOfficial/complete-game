using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfCollider : MonoBehaviour
{
    public Player player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            player.health = 0;
        }
    }
}

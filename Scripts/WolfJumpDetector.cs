using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfJumpDetector : MonoBehaviour
{
    public bool isInGround = true;

    void OnTriggerExit2D(Collider2D col)
    {
        isInGround = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isInGround = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPack : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform player;
    public float speed = 20f;
    
    float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, player.position.y), speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("should jump");
        if (col.tag == "JumpPoint")
            rb.AddForce(new Vector2(0f, 800f));
    }
}

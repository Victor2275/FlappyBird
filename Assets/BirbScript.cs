using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BirbScript : MonoBehaviour
{
    public float flap;
    public float gravity;

    public Rigidbody2D fisix;
    // Start is called before the first frame update
    void Start()
    {
        flap = 400;
        gravity = 150;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fisix.velocity = Vector2.up * flap;
        }

        fisix.gravityScale = gravity;

        if(transform.position.y < -200)
        {
            transform.position = new Vector2(transform.position.x, -200);
            fisix.velocity = Vector2.up * flap;
        }
    }
}

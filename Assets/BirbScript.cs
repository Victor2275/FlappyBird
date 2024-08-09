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
        flap = 4;
        gravity = 1.5F;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fisix.velocity = Vector2.up * flap;
        }

        fisix.gravityScale = gravity;

        if(transform.position.y < -2)
        {
            transform.position = new Vector2(transform.position.x, -2);
            fisix.velocity = Vector2.up * flap;
        }
    }
}

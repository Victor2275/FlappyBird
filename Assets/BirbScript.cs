using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BirbScript : MonoBehaviour
{
    public float flap;
    public float gravity;
    public Logic log;
    public bool live;


    public Rigidbody2D fisix;
    // Start is called before the first frame update
    void Start()
    {
        flap = 4;
        gravity = 1.5F;
        live = true;
        log = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
        fisix.gravityScale = gravity;

        if(Input.GetKeyDown(KeyCode.Space) && live)
        {
            fisix.velocity = Vector2.up * flap;
        }

        else if(transform.position.y < -2 && live)
        {
            die();
        }
    }

    private void die()
    {
        if(live) {
            log.gameOver();
            live = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        die();
    }
}

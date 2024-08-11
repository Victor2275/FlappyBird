using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassedPipe : MonoBehaviour
{
    public Logic log;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        log = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3) { 
        log.addScore(1);
        }
    }
}

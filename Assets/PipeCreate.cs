using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCreate : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer;
    public float hightOffset;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        spawnRate = 1.5F;
        hightOffset = 1.5F;
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffset;
        float HighestPoint = transform.position.y + hightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, HighestPoint), 0), transform.rotation);
    }
}

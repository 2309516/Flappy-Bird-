using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public float spawnTime = 2;
    private float time = 0;
    public GameObject Pipes;
    public float height;

    void Update()
    {
        if (time>spawnTime)
        {
            GameObject spawn = Instantiate(Pipes);
            
            spawn.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            
            time = 0;

            Destroy(spawn, 20);
        }
        time += Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPSpawnScript : MonoBehaviour
{

    public Transform[] SpawnPoints;
    private float spawnTime = 0.5f;
    private int i;
    public GameObject[] MPPickUP;

    // Start is called before the first frame update
    void Start()
    {
        for (i = 0; i < 52; i++)
        {
            Invoke("SpawnCube", spawnTime);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCube()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int objectIndex = Random.Range(0, MPPickUP.Length);

        Instantiate(MPPickUP[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
}

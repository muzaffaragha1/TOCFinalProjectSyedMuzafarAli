using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnScript : MonoBehaviour
{
    private const int Max = 9;
    public Transform[] SpawnPoints;
    private float spawnTime = 0.5f;
    private int i;
    public GameObject[] PickUp;

    // Start is called before the first frame update
    void Start()
    {

        for(i = 0; i < 11; i++)
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
        int objectIndex = Random.Range(0, PickUp.Length);

        Instantiate(PickUp[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
}

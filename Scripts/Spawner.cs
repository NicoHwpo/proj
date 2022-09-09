using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;

    public int spawnAmount = 3;

    public float spawnOffset = 2f;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnPrefab != null)
        {
            SpawnBallons();
        }
        else
        {
            Debug.LogError("No esta asignado el prefab");
        }
    }

    void SpawnBallons()
    {
        for(int i = 0; i < spawnAmount; i++)
        {
            float newXPosition = i * spawnOffset;
            GameObject newBallon = Instantiate(spawnPrefab, new Vector3(0f,0f,0f), Quaternion.identity);
            newBallon.transform.parent = this.transform;
            newBallon.transform.localPosition = new Vector3(newXPosition, 0f, 0f);
            newBallon.name = "Pelota_" + i;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

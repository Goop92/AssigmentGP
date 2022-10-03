using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject healthPickup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 21), 5, Random.Range(-20, 21));
            Instantiate(healthPickup, randomSpawnPosition, Quaternion.identity);
        }
    }
}

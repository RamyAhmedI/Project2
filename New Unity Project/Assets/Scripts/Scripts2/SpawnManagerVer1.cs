using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerVer1 : MonoBehaviour
{
    public GameObject[] virusPrefabs;

    private float startDelay = 1.5f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVirus", startDelay, spawnInterval);
    }

    void SpawnVirus ()
    {

        int virusAmount = Random.Range(0, virusPrefabs.Length);
        Vector3 spawnPos = new Vector3(19, 0 , 86);

        Instantiate(virusPrefabs[virusAmount], spawnPos, virusPrefabs[virusAmount].transform.rotation * Quaternion.Euler(0, 0, 0));
    }
}

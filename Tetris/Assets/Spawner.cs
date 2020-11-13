using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Groups
    public GameObject[] groups;

    public void spawnNext()
    {
        //Random Index
        int i = UnityEngine.Random.Range(0, groups.Length);

        //Spawn Group at current position
        Instantiate(groups[i],
            transform.position,
            Quaternion.identity);
    }
    void Start()
    {
        spawnNext();
    }
}

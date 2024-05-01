using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minHeight = -36f;
    public float maxHeight = -5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate( pipePrefab, new Vector2(6,Random.Range(minHeight,maxHeight)), Quaternion.identity);
    }
}

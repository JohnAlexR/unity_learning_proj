using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;

    private Vector3[] spawnPositions = new Vector3[]
    {
        new Vector3(-31, (float)26.03, 0), 
        new Vector3(-31, (float)32.72, 0), 
        new Vector3(-31, (float)42.37, 0), 
        new Vector3(-31, (float)18.12, 0),
        new Vector3(-31, (float)30.57, 0),
        new Vector3(-31, (float)16.6, 0),
        new Vector3(-31, (float)30.36, 0),
        new Vector3(-31, 39, 0),
        new Vector3(-31, (float)16.61, 0), 
        new Vector3(-31, (float)32.88, 0),
       
    };

    // Array holding the spawn delay for each position
    [SerializeField] private float[] spawnDelays = new float[]
    {
        0.5f, 1.0f, 0.7f, 0.9f, 0.4f, 1.2f, 0.6f, 1.1f, 0.8f, 0.3f
    };

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            // Use the specific spawn delay for each note
            yield return new WaitForSeconds(spawnDelays[i]);
            Instantiate(objectToSpawn, spawnPositions[i], Quaternion.identity);
        }
    }
}

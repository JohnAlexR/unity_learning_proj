using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]  private GameObject objectToSpawn;
    [SerializeField] private float spawnDelay = 2f;
    // Start is called before the first frame update

    private Vector3[] spawnPositions = new Vector3[]
    {
        new Vector3(-75, 18, 0),
        new Vector3(-74, 20, 0), 
        new Vector3(-77, 23, 0),  
        new Vector3(-60, 25, 0),
        new Vector3(-63, (float)33, 0),
        new Vector3(-69, (float)29.8, 0),
        new Vector3(-60, 32, 0),
        new Vector3(-65, (float)36.8, 0),   
        new Vector3(-65, (float)27.4, 0), 
        new Vector3(-67, (float)30.2, 0), 
        new Vector3(-70, (float)18.9, 0), 
        new Vector3(-74, 19, 0), 
    };

    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        foreach (Vector3 position in spawnPositions)
        {
            yield return new WaitForSeconds(spawnDelay);
            Instantiate(objectToSpawn, position, Quaternion.identity);
        }
    }
}

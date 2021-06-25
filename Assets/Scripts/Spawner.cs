using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	
	public string spawnPointTag;
	public bool alwaysSpawn = true;
	
	public List<GameObject> prefabsToSpawn;
	
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
		foreach(GameObject spawnPoint in spawnPoints){
			int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
			{
				GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
				pts.transform.position = spawnPoint.transform.position;
			
			}
		}
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour {

    public GameObject toSpawn;

    public Text text;
    private int spawnedCubes = 0;

    private int counter = 0;
	void Start () {
		
	}
	
	void Update () {
        /*
        counter++;
        if( counter == 60)
        {
            counter = 0;
            //Spawn cube here
            Instantiate(toSpawn, new Vector3(0, 20, 0), Quaternion.identity);
        }
        */
        
	}

    public void SpawnCube()
    {
        Instantiate(toSpawn, new Vector3(0, 20, 0), Quaternion.identity);
        spawnedCubes++;
        text.text = "Spawned Cubes: " + spawnedCubes;
    }
    
}

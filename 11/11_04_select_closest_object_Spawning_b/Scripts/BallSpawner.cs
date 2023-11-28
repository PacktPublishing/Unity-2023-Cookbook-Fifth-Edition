using UnityEngine;

public class BallSpawner : MonoBehaviour {
    public GameObject prefabBall;
    private SpawnPointManager spawnPointManager;
    private float timeBetweenSpawns = 1;

    void Start () {
        spawnPointManager = GetComponent<SpawnPointManager> ();
        InvokeRepeating("CreateSphere", 0, timeBetweenSpawns);
    }

    private void CreateSphere() {
        GameObject spawnPoint = 
            spawnPointManager.GetNearestSpawnpoint(transform.position);

        GameObject newBall = (GameObject)Instantiate(
            prefabBall, spawnPoint.transform.position, 
            Quaternion.identity);
        Destroy(newBall, timeBetweenSpawns/2);
    }
} 


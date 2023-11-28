 using UnityEngine;

     public class SpawnPointManager : MonoBehaviour {
         private GameObject[] spawnPoints;

         void Start() {
             spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
         }

         public GameObject RandomSpawnPoint() {
             int r = Random.Range(0, spawnPoints.Length);
             return spawnPoints[r];
         }
     }


using UnityEngine;

public class CheckPoint : MonoBehaviour {
    private Vector3 respawnPosition;
    void Start () {
        respawnPosition = transform.position;
    }

    void OnTriggerEnter (Collider hit) {
        if(hit.CompareTag("Checkpoint"))
            respawnPosition = transform.position;

        if(hit.CompareTag("Death")){
            transform.position = respawnPosition;
        }
    } 
}


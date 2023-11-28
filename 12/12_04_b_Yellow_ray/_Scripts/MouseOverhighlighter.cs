using UnityEngine;
using UnityEngine.AI;

public class DebugRaySourceDestination : MonoBehaviour {
    void Update() {
        Vector3 origin = transform.position;
        Vector3 destination = GetComponent<NavMeshAgent>().destination;
        Vector3 direction = destination - origin;
        Debug.DrawRay(origin, direction, Color.yellow);
    }
}


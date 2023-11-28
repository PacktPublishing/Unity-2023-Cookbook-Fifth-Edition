using UnityEngine;
using UnityEngine.AI;

public class MoveToClickPoint : MonoBehaviour {
    public GameObject sphereDestination;
    public GameObject sphereDestinationCandidate;
    private NavMeshAgent navMeshAgent;
    private RaycastHit hit;

    void Start() {
        navMeshAgent = GetComponent<NavMeshAgent>();
        sphereDestination.transform.position = transform.position;
    }

    void Update() {
        Ray rayFromMousePoint = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (FireRayCast(rayFromMousePoint)){
            Vector3 rayPoint = hit.point;
            ProcessRayHit(rayPoint);
        }
    }

    private void ProcessRayHit(Vector3 rayPoint) {
        if(Input.GetMouseButtonDown(0)) {
            navMeshAgent.destination = rayPoint;
            sphereDestination.transform.position = rayPoint;
        }else {
            sphereDestinationCandidate.transform.position = rayPoint;
        }

    }

    private bool FireRayCast(Ray rayFromMousePoint) {
        LayerMask layerMask = ~LayerMask.GetMask("UISpheres");
        return Physics.Raycast(rayFromMousePoint, out hit, 100, layerMask);
    }
}
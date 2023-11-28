using UnityEngine;
using System.Collections;

public class ArrowNPCMovement : MonoBehaviour {
    public MyWayPoint myWaypoint;
    private bool firstWayPoint = true;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;

    void Start (){
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        HeadForNextWayPoint();
    }

    void Update () {
        float closeToDestinaton = navMeshAgent.stoppingDistance * 2;
        if (navMeshAgent.remainingDistance < closeToDestinaton){
            HeadForNextWayPoint ();
        }
    }

    private void HeadForNextWayPoint (){
        if(firstWayPoint)
            firstWayPoint = false;
        else
            myWaypoint = myWaypoint.GetNextWaypoint();

        Vector3 target = myWaypoint.transform.position;
        navMeshAgent.SetDestination (target);
    }
}
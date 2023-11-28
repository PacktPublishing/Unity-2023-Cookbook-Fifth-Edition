using UnityEngine;
using System.Collections;

public class MyWayPoint: MonoBehaviour {
    public MyWayPoint[] waypoints;

    public MyWayPoint GetNextWaypoint () {
        return waypoints[ Random.Range(0, waypoints.Length) ];
        
    }
}


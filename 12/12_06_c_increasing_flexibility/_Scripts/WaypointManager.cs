using UnityEngine;
using System;

public class WaypointManager : MonoBehaviour {
    public GameObject[] waypoints;

    public GameObject NextWaypoint (GameObject current) {
        if( waypoints.Length < 1)
            Debug.LogError ("WaypointManager:: ERROR - no waypoints have been added to array!");

        int currentIndex = Array.IndexOf(waypoints, current);
        int nextIndex = (currentIndex + 1) % waypoints.Length;

        return waypoints[nextIndex];
    }
}
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    [SerializeField] NPCPathingConfig pathConfig;
    List<Transform> waypoints;
    int waypointIndex = 0;
    int pathRange = 0;
    int startingIndex = 0;
    int endingIndex = 0; 
    int[] pathIndicies;

    void Start()
    {
        waypoints = pathConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypointIndex == 0)
        {
            determinePath();

            Vector3 startingPostition = waypoints[startingIndex].position;
            transform.position = Vector2.MoveTowards(transform.position, startingPostition, 100);
        }
        else
        {
            if(waypointIndex < pathRange)
            {
                FollowPath();
            }
        }
    }

    void determinePath()
    {
        pathRange = UnityEngine.Random.Range(2, 5);
        startingIndex = UnityEngine.Random.Range(0, 1);
        endingIndex = UnityEngine.Random.Range(0, 1);
        int[] tempPathIndicies = new int[pathRange];

        int i = 0;
        while (i < pathRange)
        {
            int tempWaypoint = UnityEngine.Random.Range(2, 6);
            var check = Array.Exists(tempPathIndicies, element => element == tempWaypoint);
            if (check == false)
            {
                tempPathIndicies[i] = tempWaypoint;
                Console.WriteLine(tempPathIndicies[i]);
                i++;
            }
        }
        pathIndicies = tempPathIndicies;
    }

    void FollowPath()
    {

        if (waypointIndex < pathRange)
        {
            Vector3 targetPosition = waypoints[pathIndicies[waypointIndex]].position;
            float delta = pathConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, delta);
            
            if(transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
    }
}

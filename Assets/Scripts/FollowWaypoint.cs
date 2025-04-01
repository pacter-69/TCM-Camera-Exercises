using NUnit.Framework;
using System;
using System.Net.Sockets;
using UnityEngine;

public class FollowWaypoint : MonoBehaviour
{
    public Transform[] Waypoints;
    public float alpha = 1f;
    public int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowWaypoints(Waypoints);
    }

    public void FollowWaypoints(Transform[] waypoints)
    {
        transform.position = Vector2.Lerp(transform.position, waypoints[index].position, alpha * Time.deltaTime);

        if (index < waypoints.Length - 1 && Vector2.Distance(transform.position, waypoints[index].position) < 0.25)
        {
            index++;
        }

    }
}

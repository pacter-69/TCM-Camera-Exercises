using System.Net.Sockets;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public float alpha = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowingTarget(target);
    }

    public void FollowingTarget(Transform target)
    {
        transform.position = Vector3.Lerp(transform.position, target.position, alpha);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseBehaviour : MonoBehaviour
{

    public float upAmount = 0.3f;
    public float speed = 0.5f;

    public Vector3 dnPos;
    public Vector3 upPos;
    public Vector3 currPos;

    public void Start()
    {
        dnPos = transform.position;
        upPos = transform.position + Vector3.up * upAmount;
        currPos = dnPos;
    }

    public void Update()
    {
        transform.position =  Vector3.MoveTowards(transform.position, currPos, speed * Time.deltaTime);
    }

    public void OnMouseEnter()
    {
        Debug.Log("Mouse is over GameObject");
        currPos = upPos;
    }

    public void OnMouseExit()
    {
        Debug.Log("Mouse has exited GameObject");
        currPos = dnPos;
    }
}

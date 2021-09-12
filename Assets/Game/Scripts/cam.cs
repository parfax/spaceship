using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public float speed = 1.0f,distnc,maxDistnc,sprint;
    private float startSpeed;
    public Transform target;
    void Start()
    {
        startSpeed = speed;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > distnc)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        if(Vector3.Distance(transform.position, target.position) > maxDistnc)
        {
            speed = sprint;
        }
        else
        {
            speed = startSpeed;
        }
    }
}

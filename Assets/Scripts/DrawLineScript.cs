using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineScript : MonoBehaviour
{
    public Transform origin;
    public Transform destination;
    public float lineDrawSpeed=6f;
    private LineRenderer lineRenderer;
    private float counter;
    private float distance;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>(); 
        lineRenderer.SetPosition(0, origin.position); 
        lineRenderer.SetWidth(.45f, .45f); 
        lineRenderer.SetPosition(1, destination.position); 
        distance = Vector3.Distance(origin.position, destination.position);
    }
    void Update()
    {
        if (counter < distance)
        {

            counter += .1f / lineDrawSpeed;
            float x = Mathf.Lerp(0, distance, counter);
            Vector3 PointA = origin.position;
            Vector3 PointB = destination.position;
            Vector3 pointAlongLine = x * Vector3.Normalize(PointB - PointA) + PointA;
            lineRenderer.SetPosition(1, pointAlongLine);
        }
    }
}
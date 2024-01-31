using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public List<Vector2> points;
    public float pointThreshold = 0.2f;    
    Vector2 lastPos;
    LineRenderer lineRenderer;
    // Start is called before the first frame update

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
    }

    private void OnMouseDown()
    {
        points = new List<Vector2>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);

    }

    private void OnMouseDrag()
    {
        Vector2 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Vector2.Distance(currentPos, lastPos) > pointThreshold) 
        {
            points.Add(currentPos);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, currentPos);
        }

        lastPos = currentPos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer lr;
    public List<Transform> points;
    private Transform ch;
    // Start is called before the first frame update
    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 0;                
        points = new List<Transform>();
    }

    public void AddPoint(Transform point)
    {       
        if (!points.Contains(point))
        {
            add(point);
        }               
    }
    public void add(Transform point)
    {
        lr.positionCount++;
        points.Add(point);    

    }
    
    private void Update()
    {
        for(int i =0;i< points.Count; i++)
        {           
            lr.SetPosition(i, points[i].position);
        }
    }

}

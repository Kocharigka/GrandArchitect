using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DrawScript : MonoBehaviour
{
   
    public GameObject lr;    
    private Transform initPoint;
    private LineController adr;
    public GameObject drawPointsParent;   

    private void Start()
    {
     adr = lr.GetComponent<LineController>();       
    }
    private void OnMouseDown()
    {             
        if (adr.inAction)
        {
            Debug.Log(adr.points.Count);
            if (transform==initPoint && adr.points.Count >3)
            {
                adr.add(transform);
                adr.inAction = false;
                endDraw();
            } 
            
            if(!adr.points.Contains(transform))           
            {               
                adr.add(transform);               
            }
        }
        if (adr.points.Count == 0)
        {           
            initPoint = transform;
            adr.add(initPoint);           
            adr.inAction = true;
        }

    }
    
    
    public void endDraw()
    {
        var points = new List<Vector2>();
        foreach (var point in adr.points)
        {
            if (point != null)
            {
                var point2 = new Vector2(point.localPosition.x, point.localPosition.y);
                points.Add(point2);
            }
        }
        lr.AddComponent<EdgeCollider2D>();
        lr.GetComponent<EdgeCollider2D>().points = points.ToArray();
        var allChildren = drawPointsParent.GetComponentInChildren<Transform>();
        foreach (Transform child in allChildren)
        {           
                Destroy(child.gameObject);
        }
    }
}


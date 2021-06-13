using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

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
            if (transform==initPoint && adr.points.Count >3)
            {
                adr.add(transform);
                adr.inAction = false;
                endDraw();
            }

            if (transform == adr.points[adr.points.Count-2])
            {
                if (adr.points.Count == 2)
                {
                    adr.points.Clear();
                    initPoint = null;
                    adr.inAction = false;
                }
                adr.del(transform);
            }
            
            if(!adr.points.Contains(transform))           
            {               
                adr.add(transform);               
            }
        }
        if (adr.points.Count == 0)
        {
            var obj=GameObject.Find("StartDrawTip");
            if(obj!= null)
            {
                obj.SetActive(false);
                //adr.starttip4
            }
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
        if (adr.FormulaTip!=null)        
        {
            //end tip 4
            adr.FormulaTip.SetActive(true);
        }
        foreach (Transform child in allChildren)
        {           
                Destroy(child.gameObject);
        }
    }
}


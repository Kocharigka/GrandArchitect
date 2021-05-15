using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDrawButtonScript : MonoBehaviour
{
    public GameObject lrObj;
    public GameObject drawPointsParent;
    public void endDraw()
    {
        var lr = lrObj.GetComponent<LineController>();       
        lr.add(lr.points[0]);        

        var points = new List<Vector2>();
        foreach(var point in lr.points)
        {
            var point2 = new Vector2(point.localPosition.x, point.localPosition.y);
            points.Add(point2);
        }
        lrObj.AddComponent<EdgeCollider2D>();
        lrObj.GetComponent<EdgeCollider2D>().points = points.ToArray();



        var allChildren = drawPointsParent.GetComponentInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            if (!lr.points.Contains(child))
                Destroy(child.gameObject);           

        }        
        

    }   
}

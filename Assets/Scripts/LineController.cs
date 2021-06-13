using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer lr;
    public List<Transform> points;
    public bool inAction=false;
    private Transform actionPoint;
    private Vector3 mousePos;
    private int pointCount=0;
    public Transform inputParent;
    public GameObject FormulaTip = null;
    //tip4

    
    // Start is called before the first frame update
    private void Awake()
    {
        lr = GetComponent<LineRenderer>();                   
        points = new List<Transform>();        
        mousePos = new Vector3(0, 0, 0);
    }
    public void del(Transform point)
    {
        points.Remove(point);
        pointCount -= 1;
        points[pointCount] = point;
        killChild();
    }
    public void add(Transform point)
    {
        points.Add(null);
        points[pointCount]=point;
        pointCount += 1;
        killChild();
        
    }    
    private void killChild()
    {
        var allChildren = inputParent.GetComponentInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            Destroy(child.gameObject);
        }
    }
    
    private void Update()
    {
        if (inAction)
        {
            var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var currentPos = new Vector3(worldPos.x, worldPos.y, 0);            
            mousePos = currentPos;
            var trans = new GameObject();
            trans.transform.parent = inputParent;
            trans.transform.position = mousePos;
            actionPoint = trans.transform;
            if(pointCount+1>points.Count)
                points.Add(null);
            points[pointCount] = actionPoint;
            setPositions();            
        }       
    }

   private void setPositions()
    {
        if (points[0] !=null)
        {
            lr.positionCount = pointCount+1;
            for (int i = 0; i <= pointCount; i++)
            {
                lr.SetPosition(i, points[i].position);
            }
        }
    }
}

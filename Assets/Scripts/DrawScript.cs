using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawScript : MonoBehaviour
{
    public GameObject lr;
   
    private void OnMouseDown()
    {
        Debug.Log("Get point");
        var adr=lr.GetComponent<LineController>();
        adr.AddPoint(transform);
    }    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrawPoints : MonoBehaviour
{
    public GameObject drawPoint;
    public Sprite sprite;
    public GameObject lr;
    void Start()
    {
       

        for (float x = -3.5f; x <= 3f; x += 0.4f)
        {
            for (float y = -1.5f; y <= 3f; y += 0.4f)
            {
                var obj = Instantiate(drawPoint);
                obj.GetComponent<DrawScript>().lr=lr;
                obj.GetComponent<DrawScript>().drawPointsParent =gameObject;
                obj.transform.parent = transform;
                obj.transform.position = new Vector3(x, y, 0);
                obj.transform.localScale = new Vector3(0.02f, 0.02f, 0);
                obj.layer = 4;
            }
        }
    }    
}

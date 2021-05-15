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
       

        for (float x = -3.7f; x <= 2.8f; x += 0.4f)
        {
            for (float y = -0.8f; y <= 3.7f; y += 0.4f)
            {
                var obj = Instantiate(drawPoint);
                obj.GetComponent<DrawScript>().lr=lr;                
                obj.transform.parent = transform;
                obj.transform.position = new Vector3(x, y, 0);
                obj.transform.localScale = new Vector3(0.02f, 0.02f, 0);
                obj.layer = 4;
            }
        }
    }    
}

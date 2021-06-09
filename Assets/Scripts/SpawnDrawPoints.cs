using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrawPoints : MonoBehaviour
{
    public GameObject drawPoint;
    public Sprite sprite;
    public GameObject lr;
    void Awake()
    {
        int i = 0;      
       

        for (float x = -3f; x <= 3.5f; x += 0.3f)
        {
            i += 1;
            int j = 0;
            for (float y = -1.5f; y <= 3.5f; y += 0.3f)
            {
                j += 1;               
                var obj = Instantiate(drawPoint);
                obj.GetComponent<DrawScript>().lr=lr;
                obj.GetComponent<DrawScript>().drawPointsParent =gameObject;
                obj.transform.parent = transform;
                obj.transform.position = new Vector3(x, y, 0);
                obj.transform.localScale = new Vector3(0.02f, 0.02f, 0);
                obj.layer = 4;
                if (i == 8 && j == 6)
                {                   
                    obj.name = "RedDot1";
                }
                if (i == 6 && j == 7)
                {                   
                    obj.name = "RedDot2";
                }
            }
        }
    }    
}

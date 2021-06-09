using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDotScript : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        var dot=GameObject.Find(name);
        dot.GetComponent<SpriteRenderer>().color = Color.red;

    }

   
   
}

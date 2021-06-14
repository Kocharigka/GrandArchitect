using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIpsManager : MonoBehaviour
{  
    void Start()
    {
        var gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (!gm.getToggle())
            gameObject.SetActive(false);
    }    
    
}

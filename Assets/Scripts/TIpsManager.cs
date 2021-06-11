using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIpsManager : MonoBehaviour
{  
    void Start()
    {
        if(PlayerPrefs.HasKey("tipsOn"))
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }    
    
}

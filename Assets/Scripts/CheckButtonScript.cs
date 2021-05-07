using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckButtonScript : MonoBehaviour
{
    public Canvas canvas;    
    public void showCanvas()
    {       
        canvas.gameObject.SetActive(true);        
    }
}

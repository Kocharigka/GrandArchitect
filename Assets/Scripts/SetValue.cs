using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetValue : MonoBehaviour
{
    public Slider pb;
    public Text value;
    // Start is called before the first frame update
    void Start()
    {
        value.text =Mathf.Round( pb.value * 100) + "%";
    }   
}

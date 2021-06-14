using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tipsToggle : MonoBehaviour
{
    public GameObject gmobj;
    private GameManager gm;
    private static bool toggle=true;
    // Start is called before the first frame update
    void Start()
    {
        gm = gmobj.GetComponent<GameManager>();
        GetComponent<Toggle>().isOn = toggle;
        
    }

    // Update is called once per frame
    public void Toggle()
    {
        Debug.Log("Toggle");
        toggle = GetComponent<Toggle>().isOn;
        gm.toggle(toggle);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgression : MonoBehaviour
{
    public GameObject gmobj;
    private GameManager gm;
    private Dictionary<string, float> dict;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button final;
    private static bool lvl1=false;
    private static bool lvl2 = false;
    private static bool lvl3 = false;
    private static bool _final = false;


    // Start is called before the first frame update
    void Start()
    {
        gm = gmobj.GetComponent<GameManager>();
        dict = gm.loadProgr();
        if (!gm.IsRes())
        {
            lvl1 = false;
            lvl2 = false;
            lvl3 = false;
            _final = false;
        }
        if(dict.ContainsKey("persLVL1")||lvl1)
        {
            button2.interactable = true;
            lvl1 = true;

        }
        if (dict.ContainsKey("persLVL2") || lvl2)
        {
            button3.interactable = true;
            lvl2 = true;
        }
        if (dict.ContainsKey("persLVL3") || lvl3)
        {
            button4.interactable = true;
            lvl3 = true;
        }
        if (dict.ContainsKey("persLVL4") || _final)
        {
            button4.interactable = true;
            lvl3 = true;
            _final = true;
        }

    }

    // Update is called once per frame
    
}

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

    // Start is called before the first frame update
    void Start()
    {
        gm = gmobj.GetComponent<GameManager>();
        dict = gm.loadProgr();
        if(dict.ContainsKey("persLVL1"))
        {
            button2.interactable = true;
        }
        if (dict.ContainsKey("persLVL2"))
        {
            button3.interactable = true;
        }
        if (dict.ContainsKey("persLVL3"))
        {
            button4.interactable = true;
        }

    }

    // Update is called once per frame
    
}

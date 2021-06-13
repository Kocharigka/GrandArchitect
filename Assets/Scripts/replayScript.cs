using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class replayScript : MonoBehaviour
{
    public GameObject gmobj;
    private GameManager gm;
    public Text pers;
    public Text sand;
    private Dictionary<string, float> dict;
    // Start is called before the first frame update
    void Start()
    {
        gm = gmobj.GetComponent<GameManager>();
        dict = gm.loadProgr();
        var txt = gameObject.GetComponent<Text>();
        if (dict.ContainsKey(gameObject.name))
        {
            if (gameObject.name[0] == 'p')
                txt.text = dict[gameObject.name].ToString() + "%";
            else 
                txt.text = dict[gameObject.name].ToString();
        }
        else
        {
            txt.text = "";
        }
    }

    public void replay()
    {
        if (pers.text != ""&&sand.text!="")
        {            
            gm.rmProgr(dict[pers.name], (int)dict[sand.name]);
            gm.rmKey(pers.name);
            gm.rmKey(sand.name);
        }

    }

  
    
}

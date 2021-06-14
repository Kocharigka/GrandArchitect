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
        else if(txt!=null)
        {
            txt.text = "";
        }
    }

    public void replay()
    {
        if (pers.text != ""&&sand.text!="")
        {           
            gm.rmProgr(dict[pers.name]/100, (int)dict[sand.name],(int)dict["diffLVL" + sand.name[sand.name.Length - 1]]);          
            gm.rmKey(pers.name);           
            gm.rmKey(sand.name);           
            gm.rmKey("diffLVL" + sand.name[sand.name.Length - 1]);
        }

    }

  
    
}

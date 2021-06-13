using System.Collections;


using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class leaderbordScript : MonoBehaviour
{
    public List<Text> plases;
    private Dictionary<string, int> players;
    public GameObject gmobj;
    private GameManager gm;
    // Start is called before the first frame update
    private void Awake()
    {
        players = new Dictionary<string, int>();
        players.Add("ярсдемр#32", 2000);
        players.Add("ярсдемр#10", 1950);
        players.Add("ярсдемр#20", 1700);
        players.Add("ярсдемр#38", 1200);
        players.Add("ярсдемр#18", 1000);
        gm = gmobj.GetComponent<GameManager>();
       

    }
    void Start()
    {
        if (players.ContainsKey(gm.getNick()))
            players.Remove(gm.getNick());
        players.Add(gm.getNick(), gm.getRes());
        var ordered = players.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        var ordKeys = ordered.Keys.ToList();
        var ordValues = ordered.Values.ToList();
        Debug.Log(ordKeys.Count);
        Debug.Log(ordValues.Count);
        Debug.Log(plases.Count);


        for (int i = 0; i < plases.Count; i++)
        {
            
            var space = "          ";
            
            if (i == 2) 
            {
               space= "                 ";
            }

            plases[i].text = (i+1)+"     "+ordKeys[i]+space+ordValues[i]+"   нвйх";
        }
    }

    
   
}

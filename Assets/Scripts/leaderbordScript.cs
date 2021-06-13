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
    private string nick;
    public Image highlight;
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
        nick = gm.getNick();
        players.Add(nick, gm.getRes());       
        var ordered = players.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        var ordKeys = ordered.Keys.ToList();
        var ordValues = ordered.Values.ToList();
        Debug.Log(ordKeys.Count);
        Debug.Log(ordValues.Count);
        Debug.Log(plases.Count);


        for (int i = 0; i < plases.Count; i++)
        {
            var space = "          ";
            if (ordKeys[i] == nick)
            { 
                space = "                 ";
                highlight.rectTransform.position = new Vector3(highlight.rectTransform.position.x, 
                    plases[i].rectTransform.position.y, 0);
                plases[i].fontSize = 20;
            }
            plases[i].text = (i+1)+"     "+ordKeys[i]+space+ordValues[i]+"   нвйх";
        }
    }

    
   
}

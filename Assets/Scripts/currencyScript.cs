using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currencyScript : MonoBehaviour
{
    private GameObject gmobj;
    private GameManager gm;
    private Text currency=null;
    // Start is called before the first frame update
    void Start()
    {
        currency=GetComponent<Text>();
        gmobj = GameObject.Find("GameManager");
        gm = gmobj.GetComponent<GameManager>();
        var cur = gm.setCurrency();
        if (currency != null)
            currency.text = cur.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

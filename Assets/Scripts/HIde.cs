using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIde : MonoBehaviour
{
    public GameObject toHideImage=null;
    public GameObject toShowImage=null;
    private GameObject gmobj;
    private GameManager gm;
    
    void Start()
    {
        gmobj = GameObject.Find("GameManager");
        gm = gmobj.GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    public void hideImage()
    {        
        if(toHideImage!=null)
            toHideImage.SetActive(false);
    }
    public void showImage()
    {
        if (toShowImage != null &&gm.getToggle())
            toShowImage.SetActive(true);
    }
}

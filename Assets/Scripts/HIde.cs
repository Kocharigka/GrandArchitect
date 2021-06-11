using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIde : MonoBehaviour
{
    public GameObject toHideImage=null;
    public GameObject toShowImage=null;
    // Start is called before the first frame update
   public void hideImage()
    {        
        if(toHideImage!=null)
            toHideImage.SetActive(false);
    }
    public void showImage()
    {
        if (toShowImage != null && PlayerPrefs.HasKey("tipsOn"))
            toShowImage.SetActive(true);
    }
}

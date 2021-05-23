using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIde : MonoBehaviour
{
    public GameObject toHideImage;
    public GameObject toShowImage;
    // Start is called before the first frame update
   public void hideImage()
    {        
        toHideImage.SetActive(false);
    }
    public void showImage()
    {
        toShowImage.SetActive(true);
    }
}

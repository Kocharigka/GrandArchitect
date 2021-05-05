using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClickPaste : MonoBehaviour
{
    public GameObject relatedButton;
    public Text selftext;
    public Text relatedText;

    // Start is called before the first frame update
    public void onPasteClick()
    {
        if (relatedButton.GetComponent<Outline>().effectColor == Color.red)
        {
            relatedButton.GetComponent<Outline>().effectColor = Color.black;
            selftext.text = relatedText.text;
        }

    }
}

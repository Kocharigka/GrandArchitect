using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTips : MonoBehaviour
{
    public Text points;
    public Text answer;
    public GameObject firstTip;
    public GameObject secondTip;
    public GameObject thirdTip;
    public GameObject firstCount;
    public GameObject secondCount;
    public GameObject thirdCount;
    private bool first;
    private bool second;
    private bool third;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (points.text == "0"&&!first)
        {
            firstTip.SetActive(false);
            secondTip.SetActive(true);
            first = true;
        }
        if((firstCount.GetComponent<Outline>().effectColor==Color.red||
            secondCount.GetComponent<Outline>().effectColor == Color.red||
            thirdCount.GetComponent<Outline>().effectColor == Color.red)&&!second)
        {
            secondTip.SetActive(false);
            second = true;
        }

        if(answer.text!= "Ответ:______ед2"&&!third)
        {          
            thirdTip.SetActive(true);
            third = true;
        }
    }
}

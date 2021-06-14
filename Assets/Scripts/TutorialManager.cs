using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public int currentBag = 5000;
    public float progress = 0;
    public Text bagText;
    public Slider progressBar;
    public Text spentPoints;
    private int currentPoints;
    private int maxPoints;
    private bool zero = false;
    public Button answerButton;

    private void Start()
    {
        currentPoints = int.Parse(spentPoints.text);
        bagText.text = currentBag.ToString();
        maxPoints = currentPoints;

    }

    private void Update()
    {

        bagText.text = currentBag.ToString();
        progressBar.value = progress;
    }
    public void spend()
    {
        if (spentPoints.text == "0")
        {
            if (!zero)
            {
                currentBag -= 1000;
                bagText.text = currentBag.ToString();
                currentPoints -= 1000;
                zero = true;
            }
        }
        else if (currentBag != 0)
        {
            currentBag -= 1000;
            bagText.text = currentBag.ToString();
            currentPoints -= 1000;
        }
        else bagText.color = Color.red;
    }

    public void refill()
    {
        currentBag += maxPoints - currentPoints;
    }
    public void newProgress()
    {
        progress += answerButton.GetComponent<CheckButtonScript>().getAnswer() / 100;
    }   
}

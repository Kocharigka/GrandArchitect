using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentBag = 16000;
    public static float progress = 0;
    public Text bagText=null;
    public Slider progressBar;
    public Text spentPoints=null;
    private int currentPoints=0;
    private int maxPoints=0;
    private bool zero = false;
    public Button answerButton=null;

    private void Start()
    {
        if(spentPoints!=null)
        {
            currentPoints = int.Parse(spentPoints.text);
        }

        if (bagText != null)
        {
            bagText.text = currentBag.ToString();
        }

        maxPoints = currentPoints;
        progressBar.value = progress;

    }

    private void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            progress = 1000;
        }
        if (Input.GetKeyDown("b"))
        {
            currentBag = 100000;
        }       
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
        progress += getProgr();
    }

    public float getProgr()
    {
        return answerButton.GetComponent<CheckButtonScript>().getAnswer() / 400;
    }


    public void winOrLose()
    {
        if (progress > 0.9)
            SceneManager.LoadScene("WinSceneScarab");
        else
            SceneManager.LoadScene("LoseSceneScarab");

    }
    public float setProgr()
    {
        return progress;
    }

    public void removeProgr()
    {
        progress -= getProgr();
    }

}

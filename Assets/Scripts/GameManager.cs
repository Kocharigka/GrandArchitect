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
    public Slider progressBar=null;
    public Text spentPoints=null;
    private int currentPoints=0;
    private int maxPoints=0;
    private bool zero = false;
    public Button answerButton=null;
    public static Dictionary<string, float> progr=new Dictionary<string, float>();
    public static int result=0;
    public static bool isRes = false;
    public static string nick="<BLANK>";
    private static int currency=0;
    public static bool toggleOn = true;
    public void toggle(bool t)
    {
        toggleOn = t;
    }
    public bool getToggle()
    {
        return toggleOn;
    }
    
    public int getRes()
    {
        return result;
    }
    public bool IsRes()
    {
        return isRes;
    }
    public void setRes(bool res)
    {
        isRes = res;
    }
   
    public string getNick()
    {
        return nick;
    }
    public void setNick(string nickname)
    {
        nick=nickname;
    }
    private void getCurrensy()
    {
        if (progress > 0.3)
        {
            currency = 100;
        }
        if (progress > 0.5)
        {
            currency = 250;
        }
        if (progress > 0.7)
        {
            currency = 400;
        }
        if (progress > 0.9)
        {
            currency = 600;
        }
    }
    public int setCurrency()
    {
        return currency;
    }
    public void dropProgr()
    {
        progress = 0;
        progr.Clear();
        result = 0;
        isRes = false;
    }

    private void Start()
    {
        getCurrensy();
        if(spentPoints!=null)
        {
            currentPoints = int.Parse(spentPoints.text);
        }

        if (bagText != null)
        {
            bagText.text = currentBag.ToString();
        }

        maxPoints = currentPoints;
        if (progress < 0) progress = 0;
        if(progressBar!=null)
            progressBar.value = progress;
     

    }

    private void Update()
    {
       // Debug.Log(currentBag);
        if (Input.GetKeyDown("p"))
        {
            progress = 1000;
        }
        if (Input.GetKeyDown("b"))
        {
            currentBag = 100000;
        }       
      //  Debug.Log(progr.Count);
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
        del();
    }
    public void newProgress()
    {
        progress += getProgr();
    }

    public float getProgr()
    {
        return answerButton.GetComponent<CheckButtonScript>().getAnswer() / 400;
    }
    public void countDiff()
    {
        result-=answerButton.GetComponent<CheckButtonScript>().getDiff();
    }
    


   
    public float setProgr()
    {
        return progress;
    }

    public void removeProgr()
    {
        progress -= getProgr();
    }
    public void rmProgr(float progr,int sand,int res)
    {
        progress -= progr;
        currentBag += sand;
        result -= 500-res;        
    }
    public void rmKey(string key)
    {
        progr.Remove(key);
    }
    
    public void SaveProgr()
    {
        result += 500;
        countDiff();
        isRes = true;
        var sName = SceneManager.GetActiveScene().name;
        var persName = "persLVL" + sName[5];
        var sandName = "sandLVL" + sName[5];
        var diffName = "diffLVL" + sName[5];
        del();

        progr.Add(persName,Mathf.Round(getProgr()*100));
       
        progr.Add(diffName, answerButton.GetComponent<CheckButtonScript>().getDiff());
        progr.Add(sandName, maxPoints - currentPoints);       
    }
    public void del()
    {
        var sName = SceneManager.GetActiveScene().name;
        var persName = "persLVL" + sName[5];
        var sandName = "sandLVL" + sName[5];
        var diffName = "diffLVL" + sName[5];
        if (progr.ContainsKey(persName))
        {
            progr.Remove(persName);
        }
        if (progr.ContainsKey(sandName))
        {
            progr.Remove(sandName);
        }
        if (progr.ContainsKey(diffName))
        {
            progr.Remove(diffName);
        }
    }

    public Dictionary<string,float> loadProgr()
    {
        return progr;
    }

}

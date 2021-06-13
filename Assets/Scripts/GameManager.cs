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
    public static int result=2000;
    public static bool isRes = false;
    public static string nick="<BLANK>";
    private static int currency=0;
    
    public int getRes()
    {
        Debug.Log("getRes");
        if (result!=2000)
            return result;
        else return 0;
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
        if (progress == 0)
        {
            progr.Clear();
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
    public void rmProgr(float progr,int sand)
    {
        progress -= progr;
        currentBag += sand;
    }
    public void rmKey(string key)
    {
        progr.Remove(key);
    }
    
    public void SaveProgr()
    {
        countDiff();
       var sName=SceneManager.GetActiveScene().name;
        var persName = "persLVL" + sName[5];
        var sandName = "sandLVL" + sName[5];
        var diffName = "diffLVL" + sName[5];        
        if (progr.ContainsKey(persName))
        {
            progr.Remove(persName);
        }
        progr.Add(persName,Mathf.Round(getProgr()*100));
        if (progr.ContainsKey(sandName))
        {
            progr.Remove(sandName);
        }
        if (progr.ContainsKey(diffName))
        {
            progr.Remove(persName);
        }
        progr.Add(diffName, answerButton.GetComponent<CheckButtonScript>().getDiff());
        progr.Add(sandName, maxPoints - currentPoints);       
    }

    public Dictionary<string,float> loadProgr()
    {
        return progr;
    }

}

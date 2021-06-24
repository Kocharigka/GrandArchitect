using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckButtonScript : MonoBehaviour
{
    public Canvas canvas;
    private int maxPoints=5000;
    public Text currentPoints;
    public float square;
    public Text answer;
    public Text setCurrency;
    public Text setPoints;
    public void showCanvas()
    {       
        canvas.gameObject.SetActive(true);
        setCurrentText();
        gameObject.GetComponent<Button>().interactable = false;

    }
    public void setCurrentText() 
    {
        int spentPoints =maxPoints-int.Parse(currentPoints.text);
        setPoints.text = "Использовано песка: "+spentPoints.ToString();        
        float percents = getAnswer();  
        setCurrency.text = "ТОЧНОСТЬ ВЫЧИСЛЕНИЙ "+percents.ToString()+"%";
       

    }

    public float getAnswer()
    {
        if (answer.text == "Ответ:______ед2")
            return 0;
        float ans = float.Parse(answer.text.Replace("Ответ:", "").Replace("ед2", "").Trim());        
        var z= 100 - Mathf.Round(Mathf.Abs(ans - square) / square * 100);
        if (z > 0) return z;
        else return 0;
    }
    public int getDiff()
    {
        float ans = float.Parse(answer.text.Replace("Ответ:", "").Replace("ед2", "").Trim());
        return (int)Mathf.Abs(ans - square);
    }

}

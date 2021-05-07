using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckButtonScript : MonoBehaviour
{
    public Canvas canvas;
    public int maxPoints;
    public Text currentPoints;
    public float square;
    public Text answer;
    public Text setCurrency;
    public Text setPoints;
    public void showCanvas()
    {       
        canvas.gameObject.SetActive(true);
        setCurrentText();
        
    }
    public void setCurrentText() 
    {
        int spentPoints =maxPoints-int.Parse(currentPoints.text);
        setPoints.text = "Использовано песка: "+spentPoints.ToString()+"/8000";
        float ans = float.Parse(answer.text.Replace("Ответ:", "").Replace("ед2", "").Trim());
        Debug.Log(ans);
        Debug.Log(Mathf.Abs(ans - square));
        float percents =100-Mathf.Round(Mathf.Abs(ans-square)/square*100);        
        setCurrency.text = "ТОЧНОСТЬ ВЫЧИСЛЕНИЙ "+percents.ToString()+"%";

    }

}

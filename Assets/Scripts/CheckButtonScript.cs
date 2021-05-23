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
        setPoints.text = "������������ �����: "+spentPoints.ToString();        
        float percents = getAnswer();  
        setCurrency.text = "�������� ���������� "+percents.ToString()+"%";

    }

    public float getAnswer()
    {
        float ans = float.Parse(answer.text.Replace("�����:", "").Replace("��2", "").Trim());
        return 100 - Mathf.Round(Mathf.Abs(ans - square) / square * 100);
    }

}

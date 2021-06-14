using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filling : MonoBehaviour
{
    public GameObject gmobj;
    private GameManager gm;
    public float target = .9f;
    float speed = 0.2f;
    public Slider silder;
    public GameObject fill;
    private Image image;
    private float a = 0.4f;
    public Image winCanvas;
    public Image loseCanvas;
    public Slider slider1;
    public Slider slider2;
    private void Awake()
    {
        image = fill.GetComponent<Image>();
        gm = gmobj.GetComponent<GameManager>();
        target = gm.setProgr();
        slider1.value = target;
        slider2.value = target;
    }


    void Update()
    {
      if (silder.value < target&&silder.value<1)
        {
            a += 0.2f * Time.deltaTime;
            silder.value += speed * Time.deltaTime;
            image.color = new Color(image.color.r, image.color.g, image.color.b, a);
        }
        else
        {
            if (silder.value > 0.9f)
                winCanvas.gameObject.SetActive(true);
            else 
                loseCanvas.gameObject.SetActive(true);
        }
    }
}

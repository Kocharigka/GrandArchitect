using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filling : MonoBehaviour
{
    float target = .9f;
    float speed = 0.2f;
    public Slider silder;
    public GameObject fill;
    private Image image;
    private float a = 0.4f;
    public Image winCanvas;
    private void Awake()
    {
        image = fill.GetComponent<Image>();
    }


    void Update()
    {
      if (silder.value < target)
        {
            a += 0.2f * Time.deltaTime;
            silder.value += speed * Time.deltaTime;
            image.color = new Color(image.color.r, image.color.g, image.color.b, a);
        }
        else
        {
            winCanvas.gameObject.SetActive(true);
        }
    }
}

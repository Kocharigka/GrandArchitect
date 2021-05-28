using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicPB : MonoBehaviour
{
    public Slider newSlider;
    public Slider oldSlider;   
    private float speed = 0.2f;
    public GameObject gameManager;
    private static float progress=0;
    private void Awake()
    {
        newSlider.value = progress;
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (newSlider.value < oldSlider.value)
            newSlider.value += speed * Time.deltaTime;
    }
    public void Increment()
    {
        var a=gameManager.GetComponent<GameManager>().setProgr();
        oldSlider.value = a;
        progress = a;
    }
}

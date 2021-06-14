using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipButtonSkript : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    public void Skip()
    {
        slider.value = slider.GetComponent<Filling>().target;
        gameObject.SetActive(false);
    }
    private void Update()
    {
        if (slider.value >= slider.GetComponent<Filling>().target||slider.value==1)
            gameObject.SetActive(false);
    }

    // Update is called once per frame

}

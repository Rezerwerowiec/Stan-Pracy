using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Workplace_Accessor : MonoBehaviour
{
    Slider slider;
    float value = 0;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //slider.value = value;
    }

    public float GetValue()
    {
        return slider.value;
    }

    public void SetValue(float value)
    {
        //this.value = value;
        slider.value = value;
    }
}

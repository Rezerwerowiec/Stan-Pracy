using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Workplace_Text : MonoBehaviour
{
    public Engine eng;
    public Slider slider;
    public Image image;
    public int signal = 0;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangedValueMethod()
    {
        
        int value = (int)slider.value;
        Debug.Log("WT: " + value);
        switch (value)
        {
            case 0:
                {
                    txt.text = "POCZĄTEK";
                    image.color = Color.black;
                    break;
                }
            case 1:
                {
                    txt.text = "BIOS";
                    image.color = Color.gray;
                    break;
                }
            case 2:
                {
                    txt.text = "SRAM";
                    image.color = Color.blue;
                    break;
                }
            case 3:
                {
                    txt.text = "SYSTEM";
                    image.color = Color.red;
                    break;
                }
            case 4:
                {
                    txt.text = "STERY";
                    image.color = Color.magenta;
                    break;
                }
            case 5:
                {
                    txt.text = "KONTO";
                    image.color = Color.grey*Color.red;
                    break;
                }
        }
        if(signal == 1)
            eng.Save();
    }
}

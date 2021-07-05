using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Accessor : MonoBehaviour
{
    private Text txtO;
    private int counter = 0;
    public Engine eng;
    void Start()
    {
        txtO = GetComponent<Text>();
        txtO.text = "0 sztuk";
    }

    // Update is called once per frame
    void Update()
    {
        txtO.text = counter + " sztuk.";
    }

    public void SetAnother(int i)
    {
        counter += i;
        if (counter <= 0 || i == 0) counter = 0;
        eng.Save();
    }

    public int GetQuantity()
    {
        return counter;
    }
    public void SetQuantity(int id)
    {
        counter = id;
    }

}

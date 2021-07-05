using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Engine : MonoBehaviour
{
    public SaveController sc = null;
    public Accessor acc;
    private SaveData sd = null;
    public Workplace_Text[] WT;
    
    bool late = false;
    float timer = 0f;
    //STANOWISKA//
    public Workplace_Accessor Stanowisko1, Stanowisko2, Stanowisko3, Stanowisko4, Stanowisko5;

    void Update()
    {
        if (!late)
        {
            if (timer > 1.5f)
            {
                InitialLoadSavingSystem();
                late = true;
            }
            else timer += Time.deltaTime;
        }
        
        //sc.DeleteGame();
    }
    void InitialLoadSavingSystem()
    {
        sc = GetComponent<SaveController>();
        sd = sc.LoadGame();
        if (sd == null)
        {
            sd = new SaveData
            {
                quantity = acc.GetQuantity(),
                stanowisko_1 = Stanowisko1.GetValue(),
                stanowisko_2 = Stanowisko2.GetValue(),
                stanowisko_3 = Stanowisko3.GetValue(),
                stanowisko_4 = Stanowisko4.GetValue(),
                stanowisko_5 = Stanowisko5.GetValue(),
                test = 5
            };
            Debug.Log("NEW DATA CREATED");
        }
        else
        {
            acc.SetQuantity(sd.quantity);
            Stanowisko1.SetValue(sd.stanowisko_1);
            Stanowisko2.SetValue(sd.stanowisko_2);
            Stanowisko3.SetValue(sd.stanowisko_3);
            Stanowisko4.SetValue(sd.stanowisko_4);
            Stanowisko5.SetValue(sd.stanowisko_5);
            Debug.Log("TEST: " + sd.test);
            Debug.Log("LOADED SAVED DATA");
            Debug.Log("LOAD:" + sd.stanowisko_1 + ", " + sd.stanowisko_2 + ", " + sd.stanowisko_3);
        }
        
        
        sc.SaveGame(sd);
        foreach( Workplace_Text indeks in WT) {
            indeks.signal = 1;
        }
    }

    public void Save()
    {
        Debug.Log("SAVE:" + sd.stanowisko_1 + ", " + sd.stanowisko_2 + ", " + sd.stanowisko_3);
        sc.DeleteGame();

        sd.quantity = acc.GetQuantity();
        sd.stanowisko_1 =  Stanowisko1.GetValue();
        sd.stanowisko_2 =  Stanowisko2.GetValue();
        sd.stanowisko_3 =  Stanowisko3.GetValue();
        sd.stanowisko_4 =  Stanowisko4.GetValue();
        sd.stanowisko_5 =  Stanowisko5.GetValue();
        sd.test = 5;
        //Debug.Log(Stanowisko1.value + ", " + Stanowisko2.value + ", " + Stanowisko3.value);
        
        sc.SaveGame(sd);
    }
}

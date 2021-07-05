using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonReactor : MonoBehaviour
{
    public Accessor acc;

    public void ReactOnButton(int i)
    {
        acc.SetAnother(i);
    }
}

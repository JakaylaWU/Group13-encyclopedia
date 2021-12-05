using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class textOut : MonoBehaviour
{
    Text text;
    string str;
    public float time;

    void Start()
    {
        text = this.GetComponent<Text>();
        str = text.text;
        text.text = "";
        if (time == 0)
        {
            text.DOText(str, 10f);
        }
        else 
        {
            text.DOText(str, time);
        }

    }
}

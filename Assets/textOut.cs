using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class textOut : MonoBehaviour
{
    Text text;
    string str;
    void Start()
    {
        text = this.GetComponent<Text>();
        str = text.text;
        text.text = "";
        text.DOText(str, 10f);
    }
}

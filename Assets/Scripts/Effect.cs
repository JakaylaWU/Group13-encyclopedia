using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Effect : MonoBehaviour
{
    //Control effect flashing
    public GameObject effect;
    public GameObject effectPosition;
    public EffectBool effectBool;
    private Color HintColor = new Color(255, 255, 255, 255);
    public int flashTime;

    private void Update()
    {
        if (effectBool.closed == false)
        {
            HintColor.a = Mathf.PingPong(flashTime * Time.time, 1F);
            GetComponent<Image>().color = HintColor;
            effect.transform.position = effectPosition.transform.position;
            effect.transform.rotation = effectPosition.transform.rotation;
        }
        else 
        {
            effect.SetActive(false);
        }
    }

}

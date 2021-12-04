using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBool : MonoBehaviour
{
    public bool closed = false;

    public void OnClick ()
    {
        closed = true;
    }
}

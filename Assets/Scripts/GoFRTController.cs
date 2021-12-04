using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoFRTController : MonoBehaviour
{
    public bool goFront;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goFront = true;
        }
    }

}

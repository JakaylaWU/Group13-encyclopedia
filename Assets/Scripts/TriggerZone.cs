using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone: MonoBehaviour
{
    public GameObject triggerObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerObj.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerObj.SetActive(false);
        }
    }
}

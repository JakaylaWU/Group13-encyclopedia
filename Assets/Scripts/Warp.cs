using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public GameObject destination;
    public GameObject vrOrigin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vrOrigin.transform.position = destination.transform.position;
        }
    }
}

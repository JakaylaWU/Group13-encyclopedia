using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnDescription : MonoBehaviour
{
    public GameObject description;
    public Transform spawnPoint;

    public void Onclick() 
    {
        description.SetActive(true);
    }

    private void Update()
    {
        description.transform.position = spawnPoint.position;
        description.transform.rotation = spawnPoint.rotation;
    }

}

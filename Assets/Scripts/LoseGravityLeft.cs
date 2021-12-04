using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGravityLeft : MonoBehaviour
{
    public GameObject vrOrigin;
    public GameObject goFRTController;
    public float speed = 10f;
    public bool down = false;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            down = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (down)
        {
            float x = vrOrigin.transform.position.x;
            float y = vrOrigin.transform.position.y;
            float z = vrOrigin.transform.position.z;
            if (z > -50.7)
            {
                vrOrigin.transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
            }
            if (y > 0.5 && goFRTController.GetComponent<GoFRTController>().goFront)
            {
                vrOrigin.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            }
            if (y <0.52&&y>0.45)
            {
                goFRTController.GetComponent<GoFRTController>().goFront = false;
                down = false;
            }
        }
    }
}

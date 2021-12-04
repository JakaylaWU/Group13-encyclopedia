using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public GameObject obj;
    public ParticleSystem sys;
    
    // Start is called before the first frame update
    
    void Start()
    {
        sys = obj.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //sys.Stop();
    }
}

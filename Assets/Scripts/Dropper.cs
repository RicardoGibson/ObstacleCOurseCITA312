using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            GetComponent<Rigidbody>().useGravity = true;

        }
    }
}

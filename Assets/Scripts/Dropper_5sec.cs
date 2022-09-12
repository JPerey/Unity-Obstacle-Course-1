using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper_5sec : MonoBehaviour
{
    MeshRenderer mRRenderer;
    Rigidbody rigidRenderer;
    float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        mRRenderer = GetComponent<MeshRenderer>(); // caching a reference
        rigidRenderer = GetComponent<Rigidbody>();

        mRRenderer.enabled = false;
        rigidRenderer.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > timeToWait)
        {
            rigidRenderer.useGravity = true;
            mRRenderer.enabled = true;
        }
    }

}

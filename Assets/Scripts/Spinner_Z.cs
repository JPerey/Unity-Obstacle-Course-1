using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner_Z : MonoBehaviour
{
    [SerializeField] float xRotate = 0f;
    [SerializeField] float yRotate = 0f;
    [SerializeField] float zRotate = 1.5f;
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}

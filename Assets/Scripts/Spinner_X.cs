using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner_X : MonoBehaviour
{
    [SerializeField] float xRotate = 1.5f;
    [SerializeField] float yRotate = 0f;
    [SerializeField] float zRotate = 0f;
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}

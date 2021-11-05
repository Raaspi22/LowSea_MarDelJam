using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public Vector2 sensibility;
        

    public void RotacionCamara(float rotationImput)
    {
        if(rotationImput != 0)
        {
            transform.Rotate(Vector3.up * rotationImput * sensibility.x);
        }
    }
}

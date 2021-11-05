using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public GameObject pivot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AbrirPuerta()
    {
        if (pivot.transform.rotation.y < 100f)
        {
            pivot.transform.rotation = new Quaternion(0, 100f, 0, 0);
        }
        
    }

    void CerrarPuerta()
    {
        pivot.transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(Input.GetKey(KeyCode.E))
            {
                AbrirPuerta();
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CerrarPuerta();
        }
    }
}

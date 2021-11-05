using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleInmersion : MonoBehaviour
{
    public GameObject tubo1;
    public GameObject tubo2;
    public GameObject tubo3;
    public GameObject tubo4;

    public GameObject pivotPuerta3
        ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && tubo1 != null)
            {
                tubo1.GetComponent<Renderer>().material.color = Color.blue;
                tubo1 = null;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && tubo2 != null)
            {
               
                tubo2.GetComponent<Renderer>().material.color = Color.blue;
                tubo2 = null;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3) && tubo3 != null)
            {
                tubo3.GetComponent<Renderer>().material.color = Color.blue;
                tubo3 = null;
            }

            if (Input.GetKeyDown(KeyCode.Alpha4) && tubo4 != null)
            {
                tubo4.GetComponent<Renderer>().material.color = Color.blue;
                tubo4 = null;
            }

            if (tubo1 == null && tubo2 == null && tubo3 == null && tubo4 == null && pivotPuerta3 != null)
            {                
                pivotPuerta3.transform.rotation = new Quaternion(0, 100f, 0, 0);
                pivotPuerta3 = null;
            }
        }
    }
}

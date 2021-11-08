using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusible : MonoBehaviour
{
    public NuevoPuzzleLuz cajaDeLuz;
    private int _count = 0;

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
        
        if(Input.GetKeyUp(KeyCode.E) && _count == 0)
        {
            cajaDeLuz._tengoElFusible = true;
            this.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zona : MonoBehaviour
{
    public Transform entrada;
    public Transform salida;
    public Zona nextZona;
    public GameController gm;
    public int zona;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform GetTransformEntradaNextZona()
    {
        return nextZona.entrada;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);

        if (other.CompareTag("Player"))
        {
            gm.setZonaPlayer(GetComponent<Zona>());
        }
        if (other.CompareTag("Enemy"))
        {
            gm.setZonaEnemy(GetComponent<Zona>());
        }
    }

}

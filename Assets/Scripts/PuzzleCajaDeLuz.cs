using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCajaDeLuz : MonoBehaviour
{
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;

    public GameObject luz;
    public GameObject pivotPuerta1;

    public GameObject enemy;

    public List<GameObject> listaLuces;
    public AudioSource audioAmbiental;
    public AudioSource audioAmbientalPersecucion;
    public float anguloGiroPuerta;
    public float rotacionPuertaEjeY;

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
        if(other.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.Alpha1) && boton1 != null)
            {
                boton1.transform.position += new Vector3(-0.04f, 0, 0);
                boton1.GetComponent<Renderer>().material.color = Color.red;
                boton1 = null;
            }

            if(Input.GetKeyDown(KeyCode.Alpha2) && boton2 != null)
            {
                boton2.transform.position += new Vector3(-0.04f, 0, 0);
                boton2.GetComponent<Renderer>().material.color = Color.red;
                boton2 = null;
            }

            if(Input.GetKeyDown(KeyCode.Alpha3) && boton3 != null)
            {
                boton3.transform.position += new Vector3(-0.04f, 0, 0);
                boton3.GetComponent<Renderer>().material.color = Color.red;
                boton3 = null;
            }

            if(boton1 == null && boton2 == null && boton3 == null)
            {
                
                if(pivotPuerta1 !=null)
                {
                    pivotPuerta1.transform.rotation = new Quaternion(0, rotacionPuertaEjeY, 0 , anguloGiroPuerta);
                    pivotPuerta1 = null;
                }

                if(listaLuces != null)
                {
                    for (int i = 0; i < listaLuces.Count; i++)
                    {
                        listaLuces[i].SetActive(true);
                    }

                    if(enemy != null)
                    {
                        enemy.SetActive(true);
                        enemy.GetComponent<EnemyMovement>().speed = 1.5f;
                        enemy = null;
                    }

                    if(audioAmbiental != null)
                    {
                        audioAmbiental.Stop();
                        if(audioAmbientalPersecucion != null)
                        {
                            audioAmbientalPersecucion.Play();
                        }
                    }



                    listaLuces = null;
                }

                if(luz != null)
                {
                    luz.SetActive(true);
                    luz = null;
                }
                
            }
        }
    }
}

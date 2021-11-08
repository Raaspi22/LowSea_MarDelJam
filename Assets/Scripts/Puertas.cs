using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public GameObject pivot;
    public float ejeY;
    public float anguloRotacion;
    public Animator myAnimator;
    public bool deboAbrir = false;
    public GameObject colliderPuerta;
    public GameObject sonidoPuerta;

    // Start is called before the first frame update
    void Start()
    {
        if(myAnimator == null)
        {
            myAnimator = gameObject.GetComponent<Animator>();            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirPuerta()
    {
        deboAbrir = true;
        myAnimator.SetBool("Abrir", deboAbrir);
        sonidoPuerta.GetComponents<AudioSource>()[0].Play();
    }

    public void CerrarPuerta()
    {
        deboAbrir = false;
        myAnimator.SetBool("Abrir", deboAbrir);
        colliderPuerta.SetActive(true);
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

    private void PowerOffCollider()
    {
        colliderPuerta.SetActive(false);
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoPuzzle2 : MonoBehaviour
{
    public List<GameObject> cilindros;    
    public bool estoyDentro = false;
    public int cilindroInteracuando;
    public bool[] cilindroVacio = { false, false, false };
    public Animator myAnimator;
    public GameObject puertaPorAbrir;
    public GameObject puzzle3;
    public GameController controladora;
    public GameObject luzDelFinal;

    // Start is called before the first frame update
    void Start()
    {
        if(myAnimator == null)
        {
            myAnimator = this.gameObject.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        //fuerza para bajar
        if(estoyDentro)
        {
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                cilindroInteracuando = 0;
            }
            else if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                cilindroInteracuando = 1;
            }
            else if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                cilindroInteracuando = 2;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {   
                var forcePlayer = 0f;                                

                var currentScale = cilindros[cilindroInteracuando].transform.localScale;

                if (currentScale.y > 0.5f)
                {
                    forcePlayer = 0.1f;
                }
                else if (currentScale.y > 0.25f)
                {
                    forcePlayer = 0.05f;
                }
                else forcePlayer = 0.025f;

                cilindros[cilindroInteracuando].transform.localScale = new Vector3(1, (currentScale.y - forcePlayer), 1);                                

                if(cilindros[cilindroInteracuando].transform.localScale.y <= 0.1f)
                {
                    cilindroVacio[cilindroInteracuando] = true;

                    cilindros[cilindroInteracuando].transform.localScale = new Vector3(1, 0.1f, 1);
                }
                else myAnimator.SetBool("Interactuar", true);
            }     
            
            if(Input.GetKeyUp(KeyCode.E))
            {
                myAnimator.SetBool("Interactuar", false);
            }
        }

        // fuerza para subir
        if(cilindroVacio[0] == false && cilindros[0].transform.localScale.y < 1)
        {
            cilindros[0].transform.localScale += new Vector3(0, 0.05f*Time.deltaTime, 0);                
        }

        if (cilindroVacio[1] == false && cilindros[1].transform.localScale.y < 1)
        {
            cilindros[1].transform.localScale += new Vector3(0, 0.05f * Time.deltaTime, 0);
        }

        if (cilindroVacio[2] == false && cilindros[2].transform.localScale.y < 1)
        {
            cilindros[2].transform.localScale += new Vector3(0, 0.05f * Time.deltaTime, 0);
        }

        if(cilindroVacio[0] == true && cilindroVacio[1] == true && cilindroVacio[2] == true)
        {
            controladora.startPatrullaje();
            puertaPorAbrir.GetComponent<Puertas>().AbrirPuerta();
            puzzle3.GetComponent<Collider>().enabled = true;
            luzDelFinal.SetActive(true);
        }       

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            estoyDentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            estoyDentro = false;
            myAnimator.SetBool("Interactuar", false);
        }
    }
}

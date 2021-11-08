using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoPuzzleLuz : MonoBehaviour
{
    public List<GameObject> luzPorPrender;
    public List<GameObject> botonesLuz;
    public List<GameObject> lucesBotones;
    public List<int> _codigoCamarote;
    public List<int> _codigoMarcado;
    private int count;
    public Animator myAnimator;
    public GameObject puertaPorAbrir;
    public bool _tengoElFusible = false;
    public bool soyPuzzle1;

    public GameObject fusible2;
    public GameObject puzzle2;
    public GameController gm;
    public GameObject controlesPlayer;
    public GameObject puertaCollider;

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
            if(_tengoElFusible == false)
            { 
                switch (count)
                {
                    case 0:
                        if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) ||
                            Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5))
                        {
                            if (Input.GetKeyUp(KeyCode.Alpha1))
                            {
                                _codigoMarcado.Add(1);
                                    botonesLuz[0].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                if (_codigoMarcado[0] == _codigoCamarote[0])
                                {
                                    lucesBotones[0].GetComponent<Renderer>().material.color = Color.green;
                                }
                                else
                                {
                                    lucesBotones[0].GetComponent<Renderer>().material.color = Color.red;
                                }
                                count++;
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha2))
                            {
                                _codigoMarcado.Add(2);
                                botonesLuz[1].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                if (_codigoMarcado[0] == _codigoCamarote[0])
                                {
                                    lucesBotones[1].GetComponent<Renderer>().material.color = Color.green;
                                }
                                else
                                {
                                    lucesBotones[1].GetComponent<Renderer>().material.color = Color.red;
                                }
                                count++;
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha3))
                            {
                                _codigoMarcado.Add(3);
                                botonesLuz[2].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                if (_codigoMarcado[0] == _codigoCamarote[0])
                                {
                                    lucesBotones[2].GetComponent<Renderer>().material.color = Color.green;
                                }
                                else
                                {
                                    lucesBotones[2].GetComponent<Renderer>().material.color = Color.red;
                                }
                                count++;
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha4))
                            {
                                _codigoMarcado.Add(4);
                                botonesLuz[3].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                if (_codigoMarcado[0] == _codigoCamarote[0])
                                {
                                    lucesBotones[3].GetComponent<Renderer>().material.color = Color.green;
                                }
                                else
                                {
                                    lucesBotones[3].GetComponent<Renderer>().material.color = Color.red;
                                }
                                count++;
                            }
                            else
                            {
                                _codigoMarcado.Add(5);
                                botonesLuz[4].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                if (_codigoMarcado[0] == _codigoCamarote[0])
                                {
                                    lucesBotones[4].GetComponent<Renderer>().material.color = Color.green;
                                }
                                else
                                {
                                    lucesBotones[4].GetComponent<Renderer>().material.color = Color.red;
                                }
                                count++;
                            }                                                                        
                        }
                        break;
                    case 1:
                        if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) ||
                            Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5))
                        {
                            if (Input.GetKeyUp(KeyCode.Alpha1))
                            {
                                if (_codigoMarcado[0] != 1)
                                {
                                    _codigoMarcado.Add(1);
                                    botonesLuz[0].gameObject.transform.position -= new Vector3(0.015f, 0, 0);;
                                    if (_codigoMarcado[1] == _codigoCamarote[1])
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha2))
                            {
                                if (_codigoMarcado[0] != 2)
                                {
                                    _codigoMarcado.Add(2);
                                    botonesLuz[1].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[1] == _codigoCamarote[1])
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha3))
                            {
                                if (_codigoMarcado[0] != 3)
                                {
                                    _codigoMarcado.Add(3);
                                    botonesLuz[2].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[1] == _codigoCamarote[1])
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha4))
                            {
                                if (_codigoMarcado[0] != 4)
                                {
                                    _codigoMarcado.Add(4);
                                    botonesLuz[3].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[1] == _codigoCamarote[1])
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");

                            }
                            else
                            {
                                if (_codigoMarcado[0] != 5)
                                {
                                    _codigoMarcado.Add(5);
                                    botonesLuz[4].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[1] == _codigoCamarote[1])
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }                        
                        }
                        break;
                    case 2:
                        if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) ||
                            Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5))
                        {
                            if (Input.GetKeyUp(KeyCode.Alpha1))
                            {
                                if (_codigoMarcado[0] != 1 && _codigoMarcado[1] != 1)
                                {
                                    _codigoMarcado.Add(1);
                                    botonesLuz[0].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[2] == _codigoCamarote[2])
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha2))
                            {
                                if (_codigoMarcado[0] != 2 && _codigoMarcado[1] != 2)
                                {
                                    _codigoMarcado.Add(2);
                                    botonesLuz[1].gameObject.transform.position -= new Vector3(0.015f, 0, 0); 
                                    if (_codigoMarcado[2] == _codigoCamarote[2])
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha3))
                            {
                                if (_codigoMarcado[0] != 3 && _codigoMarcado[1] != 3)
                                {
                                    _codigoMarcado.Add(3);
                                    botonesLuz[2].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[2] == _codigoCamarote[2])
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha4))
                            {
                                if (_codigoMarcado[0] != 4 && _codigoMarcado[1] != 4)
                                {
                                    _codigoMarcado.Add(4);
                                    botonesLuz[3].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[2] == _codigoCamarote[2])
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else
                            {
                                if (_codigoMarcado[0] != 5 && _codigoMarcado[1] != 5)
                                {
                                    _codigoMarcado.Add(5);
                                    botonesLuz[4].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[2] == _codigoCamarote[2])
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                
                            }
                        
                        }
                        break;
                    case 3:
                        if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) ||
                            Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5))
                        {
                            if (Input.GetKeyUp(KeyCode.Alpha1))
                            {
                                if (_codigoMarcado[0] != 1 && _codigoMarcado[1] != 1 && _codigoMarcado[2] != 1)
                                {
                                    _codigoMarcado.Add(1);
                                    botonesLuz[0].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[3] == _codigoCamarote[3])
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha2))
                            {
                                if (_codigoMarcado[0] != 2 && _codigoMarcado[1] != 2 && _codigoMarcado[2] != 2)
                                {
                                    _codigoMarcado.Add(2);
                                    botonesLuz[1].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[3] == _codigoCamarote[3])
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha3))
                            {
                                if (_codigoMarcado[0] != 3 && _codigoMarcado[1] != 3 && _codigoMarcado[2] != 3)
                                {
                                    _codigoMarcado.Add(3);
                                    botonesLuz[2].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[3] == _codigoCamarote[3])
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");                            

                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha4))
                            {
                                if (_codigoMarcado[0] != 4 && _codigoMarcado[1] != 4 && _codigoMarcado[2] != 4)
                                {
                                    _codigoMarcado.Add(4);
                                    botonesLuz[3].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[3] == _codigoCamarote[3])
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");

                                
                            }
                            else
                            {
                                if (_codigoMarcado[0] != 5 && _codigoMarcado[1] != 5 && _codigoMarcado[2] != 5)
                                {
                                    _codigoMarcado.Add(5);
                                    botonesLuz[4].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[3] == _codigoCamarote[3])
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                                            
                            }
                                                
                        }
                        break;
                    case 4:
                        if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) ||
                            Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5))
                        {
                            if (Input.GetKeyUp(KeyCode.Alpha1))
                            {
                                if (_codigoMarcado[0] != 1 && _codigoMarcado[1] != 1 && _codigoMarcado[2] != 1 && _codigoMarcado[3] != 1)
                                {
                                    _codigoMarcado.Add(1);
                                    botonesLuz[0].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[4] == _codigoCamarote[4])
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[0].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                      
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha2))
                            {
                                if (_codigoMarcado[0] != 2 && _codigoMarcado[1] != 2 && _codigoMarcado[2] != 2 && _codigoMarcado[3] != 2)
                                {
                                    _codigoMarcado.Add(2);
                                    botonesLuz[1].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[4] == _codigoCamarote[4])
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[1].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");

                                
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha3))
                            {
                                if (_codigoMarcado[0] != 3 && _codigoMarcado[1] != 3 && _codigoMarcado[2] != 3 && _codigoMarcado[3] != 3)
                                {
                                    _codigoMarcado.Add(3);
                                    botonesLuz[2].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[4] == _codigoCamarote[4])
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[2].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                                
                            }
                            else if (Input.GetKeyUp(KeyCode.Alpha4))
                            {
                                if (_codigoMarcado[0] != 4 && _codigoMarcado[1] != 4 && _codigoMarcado[2] != 4 && _codigoMarcado[3] != 4)
                                {
                                    _codigoMarcado.Add(4);
                                    botonesLuz[3].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if (_codigoMarcado[4] == _codigoCamarote[4])
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[3].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");

                                Debug.Log("Quinto espacio: codigo marcado -> 4");
                            }
                            else
                            {
                                if (_codigoMarcado[0] != 5 && _codigoMarcado[1] != 5 && _codigoMarcado[2] != 5 && _codigoMarcado[3] != 5)
                                {
                                    _codigoMarcado.Add(5);
                                    botonesLuz[4].gameObject.transform.position -= new Vector3(0.015f, 0, 0);
                                    if(_codigoMarcado[4] == _codigoCamarote[4])
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.green;
                                    }
                                    else
                                    {
                                        lucesBotones[4].GetComponent<Renderer>().material.color = Color.red;
                                    }
                                    count++;
                                }
                                else Debug.Log("Ya tocaste esa tecla");
                               
                            }                       
                        }
                        break;
                    case 5:
                        if(Input.GetKeyUp(KeyCode.E))
                        {
                            var contador = 0;
                            for (int i = 0; i < _codigoCamarote.Count; i++)
                            {
                                if(_codigoCamarote[i] == _codigoMarcado[i])
                                {
                                    contador++;
                                }
                            }
                            
                            if(contador == 5)
                            {
                                puertaPorAbrir.GetComponent<Puertas>().AbrirPuerta();
                                
                                if (myAnimator != null)
                                {                                    
                                    myAnimator.SetBool("Abrir", true);
                                }                                
                                if(soyPuzzle1 == false)
                                {
                                    for (int i = 0; i < luzPorPrender.Count; i++)
                                    {
                                        luzPorPrender[i].SetActive(true);

                                        gm.startPersecution();
                                        controlesPlayer.GetComponent<Controls>().estoyEnCinematica = true;
                                        this.gameObject.GetComponent<Collider>().enabled = false;
                                    }
                                }
                            }
                            else
                            {                                
                                for (int i = 0; i < botonesLuz.Count; i++)
                                {
                                    botonesLuz[i].gameObject.transform.position += new Vector3(0.015f, 0, 0);
                                }
                                for (int i = 0; i < lucesBotones.Count; i++)
                                {
                                    lucesBotones[i].GetComponent<Renderer>().material.color = Color.gray;
                                }
                                _codigoMarcado.Clear();
                                count = 0;
                            }
                        }
                        break;
                }
            
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if (fusible2 != null)
                    {
                        fusible2.SetActive(true);
                    }
                    for (int i = 0; i < luzPorPrender.Count; i++)
                    {
                        luzPorPrender[i].SetActive(true);
                    }

                    if (myAnimator != null)
                    {
                        myAnimator.SetBool("Abrir", false);
                    }

                    puzzle2.GetComponent<Collider>().enabled = true;
                    puertaCollider.GetComponent<Collider>().enabled = true;
                }                
            }
        }
    }
}

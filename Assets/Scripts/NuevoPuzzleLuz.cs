using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoPuzzleLuz : MonoBehaviour
{
    public GameObject luzSalaPrincipal;
    public List<GameObject> botonesLuz;
    public List<GameObject> lucesBotones;
    public List<int> _codigoCamarote = new List<int>(5);
    public List<int> _codigoMarcado = new List<int>(5);
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        _codigoCamarote[0] = 1;
        _codigoCamarote[1] = 4;
        _codigoCamarote[2] = 2;
        _codigoCamarote[3] = 5;
        _codigoCamarote[4] = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            switch (count)
            {
                case 0:
                    if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2) ||
                        Input.GetKeyUp(KeyCode.Alpha3) || Input.GetKeyUp(KeyCode.Alpha4) || Input.GetKeyUp(KeyCode.Alpha5))
                    {
                        if (Input.GetKeyUp(KeyCode.Alpha1))
                        {
                            _codigoMarcado[0] = 1;
                            Debug.Log("Primer espacio: codigo marcado -> 1");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha2))
                        {
                            _codigoMarcado[0] = 2;
                            Debug.Log("Primer espacio: codigo marcado -> 2");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha3))
                        {
                            _codigoMarcado[0] = 3;
                            Debug.Log("Primer espacio: codigo marcado -> 3");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha4))
                        {
                            _codigoMarcado[0] = 4;
                            Debug.Log("Primer espacio: codigo marcado -> 4");
                        }
                        else
                        {
                            _codigoMarcado[0] = 5;
                            Debug.Log("Primer espacio: codigo marcado -> 5");
                        }

                        
                        count++;
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
                                _codigoMarcado[1] = 1;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Segundo espacio: codigo marcado -> 1");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha2))
                        {
                            if (_codigoMarcado[0] != 2)
                            {
                                _codigoMarcado[1] = 2;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Segundo espacio: codigo marcado -> 2");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha3))
                        {
                            if (_codigoMarcado[0] != 3)
                            {
                                _codigoMarcado[1] = 3;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Segundo espacio: codigo marcado -> 3");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha4))
                        {
                            if (_codigoMarcado[0] != 4)
                            {
                                _codigoMarcado[1] = 4;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Segundo espacio: codigo marcado -> 4");
                        }
                        else
                        {
                            if (_codigoMarcado[0] != 5)
                            {
                                _codigoMarcado[1] = 5;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Segundo espacio: codigo marcado -> 5");
                        }

                        count++;
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
                                _codigoMarcado[2] = 1;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Tercer espacio: codigo marcado -> 1");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha2))
                        {
                            if (_codigoMarcado[0] != 2 && _codigoMarcado[1] != 2)
                            {
                                _codigoMarcado[2] = 2;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Tercer espacio: codigo marcado -> 2");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha3))
                        {
                            if (_codigoMarcado[0] != 3 && _codigoMarcado[1] != 3)
                            {
                                _codigoMarcado[2] = 3;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Tercer espacio: codigo marcado -> 3");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha4))
                        {
                            if (_codigoMarcado[0] != 4 && _codigoMarcado[1] != 4)
                            {
                                _codigoMarcado[2] = 4;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Tercer espacio: codigo marcado -> 4");
                        }
                        else
                        {
                            if (_codigoMarcado[0] != 5 && _codigoMarcado[1] != 5)
                            {
                                _codigoMarcado[2] = 5;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Tercer espacio: codigo marcado -> 5");
                        }

                        count++;
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
                                _codigoMarcado[3] = 1;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Cuarto espacio: codigo marcado -> 1");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha2))
                        {
                            if (_codigoMarcado[0] != 2 && _codigoMarcado[1] != 2 && _codigoMarcado[2] != 2)
                            {
                                _codigoMarcado[3] = 2;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Cuarto espacio: codigo marcado -> 2");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha3))
                        {
                            if (_codigoMarcado[0] != 3 && _codigoMarcado[1] != 3 && _codigoMarcado[2] != 3)
                            {
                                _codigoMarcado[3] = 3;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Cuarto espacio: codigo marcado -> 3");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha4))
                        {
                            if (_codigoMarcado[0] != 4 && _codigoMarcado[1] != 4 && _codigoMarcado[2] != 4)
                            {
                                _codigoMarcado[3] = 4;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Cuarto espacio: codigo marcado -> 4");
                        }
                        else
                        {
                            if (_codigoMarcado[0] != 5 && _codigoMarcado[1] != 5 && _codigoMarcado[2] != 5)
                            {
                                _codigoMarcado[3] = 5;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Cuarto espacio: codigo marcado -> 5");
                        }

                        count++;
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
                                _codigoMarcado[4] = 1;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Quinto espacio: codigo marcado -> 1");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha2))
                        {
                            if (_codigoMarcado[0] != 2 && _codigoMarcado[1] != 2 && _codigoMarcado[2] != 2 && _codigoMarcado[3] != 2)
                            {
                                _codigoMarcado[4] = 2;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Quinto espacio: codigo marcado -> 2");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha3))
                        {
                            if (_codigoMarcado[0] != 3 && _codigoMarcado[1] != 3 && _codigoMarcado[2] != 3 && _codigoMarcado[3] != 3)
                            {
                                _codigoMarcado[4] = 3;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Quinto espacio: codigo marcado -> 3");
                        }
                        else if (Input.GetKeyUp(KeyCode.Alpha4))
                        {
                            if (_codigoMarcado[0] != 4 && _codigoMarcado[1] != 4 && _codigoMarcado[2] != 4 && _codigoMarcado[3] != 4)
                            {
                                _codigoMarcado[4] = 4;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Quinto espacio: codigo marcado -> 4");
                        }
                        else
                        {
                            if (_codigoMarcado[0] != 5 && _codigoMarcado[1] != 5 && _codigoMarcado[2] != 5 && _codigoMarcado[3] != 5)
                            {
                                _codigoMarcado[4] = 5;
                            }
                            else Debug.Log("Ya tocaste esa tecla");

                            Debug.Log("Quinto espacio: codigo marcado -> 5");
                        }

                        count++;
                    }
                    break;
                case 5:
                    if(Input.GetKeyUp(KeyCode.Space))
                    {
                        if(_codigoCamarote == _codigoMarcado)
                        {
                            Debug.Log("se abrio el camarote");
                        }
                        else
                        {
                            Debug.Log("ERROR PERRI");
                            count = 0;
                            _codigoMarcado.Clear();                            
                        }
                    }
                    break;
            }
        }
    }
}

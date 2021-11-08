using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public List<Transform> posicionesPatrullaje;
    bool atacando = false;
    bool startPatrulla = false;
    int itransform = 0;
    public float speedMovemnen;
    public float speedRotation;
    public Transform target;
    public Animator anim;
    public GameObject player;
    bool endPatrullaje = false;
    bool killPlayer = false;
    public GameObject cam;
    public float reset = 5f;
    bool resetGame = false;
    public GameController gm;
    public float distanciaSonido = 1;
    public float distanciaSonidoMuyCerca = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector3(0, 5, 0);
        target = posicionesPatrullaje[itransform];
        //startPatrullaje();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > distanciaSonido)
        {
            if (!killPlayer)//esto es para que una vez te mate no quede haciendo rrrr todo el rato
            {
                //sonido de que estas cerca del monstruo rrrr
            }
        }
        if (Vector3.Distance(transform.position, player.transform.position) > distanciaSonidoMuyCerca)
        {
            if (!killPlayer)//esto es para que una vez te mate no quede haciendo RRRRR todo el rato
            {
                //sonido de que estas cerca del monstruo RRRRR
            }
        }
        if (resetGame)
        {
            reset -= Time.deltaTime;
            if (reset <= 0)
            {
                gm.ResetScena();
            }
        }

        if (startPatrulla)
        {
            
            if (Vector3.Distance(transform.position, target.position) < 0.2)
            {
                //aqui cambio de un punto de patrullaje a otro
                itransform++;
                if (itransform < posicionesPatrullaje.Count)
                {
                    target = posicionesPatrullaje[itransform];
                }
                else
                {
                    if (!killPlayer)
                    {
                        transform.position = new Vector3(0, 5, 0);
                    }
                    startPatrulla = false;
                    endPatrullaje = true;
                }

            }
            if (atacando)
            {
                target = player.transform;

                if (!killPlayer)
                {
                    //aqui el enemigo te ve y se te va encima
                    speedMovemnen = 5;
                }
                
                if (Vector3.Distance(transform.position, target.position) < 0.2)
                {
                    
                    speedMovemnen = 0;
                    speedRotation = 0;
                    anim.Play("Idle");
                    if(!killPlayer)
                    {
                        player.GetComponent<Controls>().GameOver(transform);
                        //aqui mata al player
                        player.SetActive(false);
                        cam.SetActive(true);
                        
                    }

                    resetGame = true;
                    killPlayer = true;
                }
                
            }
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), speedRotation * Time.deltaTime);
            transform.Translate(0, 0, Time.deltaTime * speedMovemnen);
        }
    }

    public void startPatrullaje()
    {
        if (!endPatrullaje)
        {
            if (!startPatrulla)
            {
                //sonido de puerta abierta cuando entra a patrullar en la sala de control
                startPatrulla = true;
                transform.position = new Vector3(-3.74f, 0, -4.445f);
                anim.Play("Walk");
            }
        }
        
        
    }

    public void atacar()
    {
        atacando = true;
    }
}

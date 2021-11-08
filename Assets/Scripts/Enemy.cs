using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float speedMovemnen;
    public float speedRotation;
    public Transform target;
    public float pauseTime = 5f;
    bool inPause = true;
    public bool startPersecution = false;
    public Animator anim;
    public GameObject cam;
    public float reset = 5f;
    bool resetGame = false;
    public GameController gm;
    public float distanciaSonido = 1;
    public float distanciaSonidoMuyCerca = 0.5f;
    bool killPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (startPersecution)
        {
            
            if (!inPause)
            {
                if (Vector3.Distance(transform.position, player.transform.position) > 0.2)
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), speedRotation * Time.deltaTime);
                }
                else
                {
                    speedMovemnen = 0;
                    speedRotation = 0;
                    anim.Play("Idle");
                    player.GetComponent<Controls>().GameOver(transform);
                    killPlayer = true;
                    player.SetActive(false);
                    cam.SetActive(true);
                    resetGame = true;
                }

                transform.Translate(0, 0, Time.deltaTime * speedMovemnen);
                

            }
            else
            {
                pauseTime -= Time.deltaTime;
                if (pauseTime <= 0)
                {
                    anim.Play("Walk");
                    inPause = false;
                    //aqui el monstruo comienza a caminar luego de su aparicion repentina
                }
            }
        }
        
    }

    public void startEnemy()
    {
        startPersecution = true;
        transform.position = new Vector3(1.11f, 0, -17.77f);
        //aqui el monstruo aparece de golpe al terminar el 3º puzzle
    }
}

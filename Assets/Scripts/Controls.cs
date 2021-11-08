using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField]
    private MovementPlayer _movement;

    [SerializeField]
    private FPSCamera _FPScamera;

    public Vector2 movement = new Vector2(0,0);

    private Vector2 _myMovement;
    private float _myRotation;

    public bool estoyAgachado = false;
    public bool estoyQuieto = true;

    public bool estoyEnCinematica = false;

    public GameObject cameraPlayer;
    public GameObject cameraMain;
    private int _contadorCinematica;
    private float _timer = 3f;
    public GameObject puertaOrtiva;
    public GameObject playerTexturas;
    public bool isDead = false;
    public GameObject canvasE;


    private void Awake()
    {
        

    }

    // Update is called once per frame
    private void Update()
    {
        if(estoyEnCinematica ==false && isDead == false)
        {
            _myMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            _myRotation = Input.GetAxisRaw("Mouse X");

            if (Input.GetKey(KeyCode.LeftControl))
            {
                estoyAgachado = true;
            }
            else estoyAgachado = false;

            if (Input.GetKeyDown(KeyCode.Return))
            {

                _movement.Pausa();

            }

            if (_myMovement == Vector2.zero)
            {
                estoyQuieto = true;
            }
            else estoyQuieto = false;
        }
        else if(estoyEnCinematica == true)
        {
            playerTexturas.SetActive(true);
            cameraPlayer.SetActive(false);
            this.gameObject.transform.position = new Vector3(-1.71f, 0.1863632f, -17.18f);

            puertaOrtiva.GetComponents<Collider>()[0].enabled = false;            

            if(_contadorCinematica == 0)
            {
                this.gameObject.transform.rotation = new Quaternion(0, 100f, 0, 100);
                _contadorCinematica++;
            }

            cameraMain.SetActive(true);

            _timer -= Time.deltaTime;

            if(_timer <= 0)
            {
                puertaOrtiva.GetComponents<Collider>()[0].enabled = true;                
                estoyEnCinematica = false;
                cameraPlayer.SetActive(true);
                cameraMain.SetActive(false);
                playerTexturas.SetActive(false);
            }
        }
        
    }

    private void FixedUpdate()
    {
        if (estoyEnCinematica == false)
        {
            _movement.Moverse(_myMovement, estoyAgachado);
            _FPScamera.RotacionCamara(_myRotation);

            if (estoyAgachado == true)
            {
                _movement.Agacharse();
            }
            else _movement.Pararse();

            if(estoyQuieto)
            {
                _movement.DejeDeMoverme();
            }

        }
    }
       
    public void GameOver(Transform target)
    {
        isDead = true;                   
    }

    public void ControlesDetenidos()
    {
        _movement.DejeDeMoverme();
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.CompareTag("Puzzles") || other.CompareTag("Puertas"))
        {
            canvasE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Puzzles") || other.CompareTag("Puertas"))
        {
            canvasE.SetActive(false);
        }
    }


}

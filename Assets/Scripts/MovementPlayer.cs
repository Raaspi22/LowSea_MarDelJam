using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovementPlayer : MonoBehaviour
{
    #region Variables

    #region Publicas

    public static float movementSpeed = 2f;

    public float horizontalSpeed;

    public Action<bool> onMovement;

    bool _isMoving = false;

    public GameObject camara;
    public GameObject linterna;
        
    #endregion

    #region Privadas

    [SerializeField]
    private Rigidbody _myRigiBody;

    public GameObject managerAuidoPasos;
    private int random;
    private bool hayPasosSonando = false;

    #endregion

    #endregion

    private void Awake()
    {      

        if (_myRigiBody == null)
        {
                    
            _myRigiBody = GetComponent<Rigidbody>();
        
        }        
    }

    public void Pausa()
    {

        //_audioManager.NoMasDaño();

        Cursor.lockState = CursorLockMode.None;

        //_uiManager.EnPausa();

        Time.timeScale = 0;

    }

    public void Agacharse()
    {        
        camara.transform.position = new Vector3(camara.transform.position.x, 1f , camara.transform.position.z);
        linterna.transform.position = new Vector3(linterna.transform.position.x, 0.5f, linterna.transform.position.z);
        this.gameObject.GetComponent<CapsuleCollider>().height = 1.782709f / 2;        
    }

    public void Pararse()
    {
        camara.transform.position = new Vector3(camara.transform.position.x, 1.5f, camara.transform.position.z);
        linterna.transform.position = new Vector3(linterna.transform.position.x, 1f, linterna.transform.position.z);
        this.gameObject.GetComponent<CapsuleCollider>().height = 1.782709f;        
    }

    public void Moverse(Vector2 movement, bool reducirVelocidad)
    {
        if(reducirVelocidad)
        {
            movementSpeed = 1;
        }
        else movementSpeed = 2;

        if (!_isMoving)
        {
            _isMoving = true;
            onMovement(true);
        }

        var velocity = new Vector3(movement.x, 0, movement.y) * movementSpeed;


        _myRigiBody.velocity = transform.TransformDirection(velocity);

        if(!hayPasosSonando)
        {
            random = UnityEngine.Random.Range(0, 7);
            managerAuidoPasos.GetComponents<AudioSource>()[random].Play();
            hayPasosSonando = true;
        }

        if(!managerAuidoPasos.GetComponents<AudioSource>()[random].isPlaying)
        {
            hayPasosSonando = false;
        }

    }   

    public void DejeDeMoverme()
    {
        if(_isMoving)
        {
            _isMoving = false;
            onMovement(false);
        }
        managerAuidoPasos.GetComponents<AudioSource>()[random].Stop();
        movementSpeed = 0f;
        //_audioManager.DejeDeCaminar();
    }
    
}

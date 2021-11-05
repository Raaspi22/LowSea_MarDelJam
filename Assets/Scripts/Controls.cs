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


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    private void Update()
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

    private void FixedUpdate()
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
       

    public void ControlesDetenidos()
    {
        _movement.DejeDeMoverme();
    }
}

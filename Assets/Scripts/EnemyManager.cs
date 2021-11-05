using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public MovementPlayer player;
    private float _timer;

    private void OnEnable()
    {
        player.onMovement += PlayerMovementChange;
    }

    private void OnDisable()
    {
        player.onMovement -= PlayerMovementChange;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerMovementChange(bool playerIsMoving)
    {
        if (playerIsMoving)
            Debug.Log("Me muevo");
        else
        {

        }
    }
}

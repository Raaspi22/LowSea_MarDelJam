using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject targetPlayer;
    public float speed = 0;
    public AudioSource audioEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Sonido();
    }

    void Movement()
    {
        Vector3 deseado = targetPlayer.transform.position - this.gameObject.transform.position;
        deseado.Normalize();
        deseado.y = 0;
        transform.forward = deseado;
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void Sonido()
    {
        Vector3 deseado = targetPlayer.transform.position - this.transform.position;
        if(deseado.magnitude < 4)
        {
            if(!audioEnemigo.isPlaying)
            {
                audioEnemigo.Play();
            }
        }
        else
        {
            if(audioEnemigo.isPlaying)
            {
                audioEnemigo.Stop();
            }
        }
    }
}

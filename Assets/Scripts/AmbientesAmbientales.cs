using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientesAmbientales : MonoBehaviour
{
    private int random;
    

    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 2);
        this.gameObject.GetComponents<AudioSource>()[random].Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.gameObject.GetComponents<AudioSource>()[random].isPlaying)
        {
            random = Random.Range(0, 2);
            this.gameObject.GetComponents<AudioSource>()[random].Play();
        }
    }
}

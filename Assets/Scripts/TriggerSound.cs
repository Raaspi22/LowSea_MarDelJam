using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public GameObject randomAmbiente;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        random = Random.Range(0, 2);
        if (other.CompareTag("Player"))
        {
            randomAmbiente.GetComponents<AudioSource>()[random].Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            randomAmbiente.GetComponents<AudioSource>()[random].Stop();
        }
    }
}

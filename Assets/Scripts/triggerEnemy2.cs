using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEnemy2 : MonoBehaviour
{
    public Enemy2 enemy;
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
        if (other.CompareTag("Player"))
        {
            enemy.atacar();
        }
    }
}

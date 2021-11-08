using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public Zona zonaEnemy;
    public Zona zonaPlayer;
    public GameObject bloqueo;
    public Enemy2 enemy2;
    public CambiadorEscena cambiador;

    public int zonaenemigo=0;
    public int zonaplayer=0;
    public float distancia=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(enemy.transform.position, zonaEnemy.salida.position);
        zonaenemigo = zonaEnemy.zona;
        zonaplayer = zonaPlayer.zona;
        if (zonaPlayer.zona==zonaEnemy.zona)
        {
            if(Vector3.Distance(enemy.transform.position, zonaEnemy.salida.position) > Vector3.Distance(enemy.transform.position, player.transform.position))
            {
                enemy.GetComponent<Enemy>().target = player.transform;
            }
            else
            {
                if (zonaPlayer.zona == 5)//no me preguntes por esta linea (?
                {
                    enemy.GetComponent<Enemy>().target = player.transform;
                }
                else
                {
                    enemy.GetComponent<Enemy>().target = zonaEnemy.salida;
                }
                
            }
            
        }
        else
        {
            if(Vector3.Distance(enemy.transform.position,zonaEnemy.salida.position)>0.4)
            {
                enemy.GetComponent<Enemy>().target = zonaEnemy.GetTransformEntradaNextZona();
            }
            else
            {
                enemy.GetComponent<Enemy>().target = zonaEnemy.salida;
            }
            
        }
    }

    public void setZonaEnemy(Zona nueva)
    {
        zonaEnemy = nueva;
    }

    public void setZonaPlayer(Zona nueva)
    {
        zonaPlayer = nueva;
    }

    public void startPersecution()
    {
        enemy.GetComponent<Enemy>().startEnemy();
        bloqueo.transform.position = new Vector3(0.33f, 1.19f, -2.24f);
        
    }

    public void startPatrullaje()
    {
        enemy2.startPatrullaje();
    }

    public void ResetScena()
    {
        cambiador.ChangeScene("Derrota");
    }
}

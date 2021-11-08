using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicaCambiarEscena : MonoBehaviour
{
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <=0)
        {
            Debug.Log("estoy aca");
            ChangeScene("Level");
        }
    }

    public void ChangeScene(string nameScene)
    {        
        SceneManager.LoadScene(nameScene);
    }
}

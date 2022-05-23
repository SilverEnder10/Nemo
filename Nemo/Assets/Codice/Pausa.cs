using UnityEngine;
using UnityEngine.SceneManagement;


public class Pausa : MonoBehaviour {


public GameManager gamemanager;
    

    public void pausagioco () {


    Time.timeScale = 0;
    gamemanager.pausa();
        

    }

 
}
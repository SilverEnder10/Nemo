using UnityEngine;


public class Riprendi : MonoBehaviour {
    
    
public GameManager gamemanager;


    public void riprendigioco () {


        Time.timeScale = 1;
        gamemanager.riprendi();
        

    }

 
}
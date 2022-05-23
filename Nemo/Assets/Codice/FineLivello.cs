using UnityEngine;


public class FineLivello : MonoBehaviour {
   
    
    public GameManager gamemanager;


    void OnTriggerEnter () {


        gamemanager.livellocompletato();
        

    }


}

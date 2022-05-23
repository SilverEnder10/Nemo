using UnityEngine;
using UnityEngine.SceneManagement;


public class Inizio : MonoBehaviour {
    
   
    public void InizioGioco () {


        //Debug.Log("inizio");
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);


    }


}

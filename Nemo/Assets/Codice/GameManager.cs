using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {
    

    public GameObject testolivellocompletato;

    public GameObject menupausa;

    public GameObject cheat;

    bool finegioco = false;

    public float restartDelay = 1f;


    public void livellocompletato () {


        testolivellocompletato.SetActive(true);
        

    }


    public void pausa () {


        menupausa.SetActive (true);


    }

    
    public void riprendi () {


        menupausa.SetActive (false);


    }


    public void gamemaster () {


        cheat.SetActive(false);
        

    }


    public void gameover () {


        if (finegioco == false) {


            finegioco = true;
            Invoke ("Restart", restartDelay);


        }


    }
    

    void Restart () {

        
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);


    }


}

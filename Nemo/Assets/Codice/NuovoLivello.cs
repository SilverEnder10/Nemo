using UnityEngine;
using UnityEngine.SceneManagement;


public class NuovoLivello : MonoBehaviour {
    

    public void caricanuovolivello () {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


}

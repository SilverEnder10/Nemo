using UnityEngine;
using UnityEngine.UI;


public class Punteggio : MonoBehaviour {


    public Transform giocatore;
    public Text punteggioText;


    // Update is called once per frame
    void Update() {


        //Debug.Log(giocatore.position.z); 
        punteggioText.text = giocatore.position.z.ToString("Distanza: "+"0"+"M");
            
            
    }


}

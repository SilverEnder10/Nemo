using UnityEngine;


public class SeguiGiocatore : MonoBehaviour {
    

    public Transform giocatore;
    public Vector3 offset;


    // Update is called once per frame
    void Update() {


        //Debug.Log (giocatore.position);
        transform.position = giocatore.position + offset;
        

    }


}

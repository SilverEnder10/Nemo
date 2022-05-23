using UnityEngine;


public class Frizione : MonoBehaviour {


    void OnCollisionEnter (Collision gameObject) {


        if (gameObject.collider.tag == "Giocatore") {

        
            //Debug.Log (" Scontro con parete");
            gameObject.collider.material.dynamicFriction = 0;
            gameObject.collider.material.staticFriction = 0;
            

        }


    }

 
}

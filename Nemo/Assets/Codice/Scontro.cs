using UnityEngine;


public class Scontro : MonoBehaviour {


    public Movimento movimento;


    void OnCollisionEnter (Collision collisionInfo) {


        if (collisionInfo.collider.tag == "Ostacolo") {


            //Debug.Log (" Scontro con ostacolo");
            movimento.enabled = false;
            FindObjectOfType <GameManager>().gameover();
            

        }


    }


}

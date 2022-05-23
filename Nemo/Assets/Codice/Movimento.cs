using UnityEngine;


public class Movimento : MonoBehaviour {


    public Rigidbody rb;
    public float forzavanti = 12500f;
    public float forzalati = 250f;


    // Update is called once per frame
    void FixedUpdate() {
            

        rb.AddForce (0, 0, +forzavanti * Time.deltaTime);


        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {


            rb.AddForce (-forzalati * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }


        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {


            rb.AddForce (+forzalati * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }


        if (Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.RightAlt) && (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))) {


            forzavanti = forzavanti + 1000f;


        }


        if (Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.RightAlt) && (Input.GetKey("s") || Input.GetKey(KeyCode.UpArrow))) {


            forzavanti = forzavanti - 1000f;


        }


        if (Input.GetKey(KeyCode.RightControl) && Input.GetKey(KeyCode.RightAlt) && Input.GetKey("g")) {


            FindObjectOfType <GameManager> ().gamemaster();


        }


        if (Input.GetKey(KeyCode.Escape)) {


            Time.timeScale = 0;
            FindObjectOfType <GameManager> ().pausa();


        }


        if (rb.position.y < -1f) {

            
            FindObjectOfType<GameManager> ().gameover();


        }


    }

    
}

using UnityEngine;

public class PlayerControl : MonoBehaviour {

    void Update() {

        if (!Parameters.instance.Moveable) return; 

        // if (Input.GetKey(KeyCode.A))
 	    // transform.Rotate(Vector3.up * Parameters.instance.RotateSpeed * Time.deltaTime);
 	
        // if (Input.GetKey(KeyCode.D))
 	    // transform.Rotate(-Vector3.up * Parameters.instance.RotateSpeed * Time.deltaTime);

        /// <summary>-------   Rotate    ------- </summary>    
        var movementH = Input.GetAxis("Horizontal");
        References.instance.Player.transform.Rotate (-1 * movementH * Parameters.instance.RotateSpeed * Time.deltaTime * Vector3.forward);

        if (Input.GetKeyDown(KeyCode.Space)) {   

        }
        
    }

}

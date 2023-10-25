using UnityEngine;

public class PlayerControl : MonoBehaviour {

    void Update() {

        if (!Parameters.instance.Moveable) return; 

        var movementH = Input.GetAxis("Horizontal");
        References.instance.Player.transform.Rotate (-1 * movementH * Parameters.instance.RotateSpeed * Time.deltaTime * Vector3.forward);

        if (Input.GetKeyDown(KeyCode.Space)) {   

        }
        
    }

}

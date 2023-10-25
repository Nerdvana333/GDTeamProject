using UnityEngine;

public class PlayerControl : MonoBehaviour {

    void Update() {

        if (!Parameters.instance.Moveable) return; 

        var movementH = Input.GetAxis("Horizontal");
        References.instance.Player.transform.Rotate (-1 * movementH * Parameters.instance.RotateSpeed * Time.deltaTime * Vector3.forward);

        if (References.instance.Player.transform.eulerAngles.z < 180) {
            References.instance.Player.transform.eulerAngles = new Vector3 (0, 0, Mathf.Clamp(References.instance.Player.transform.eulerAngles.z, 0, 90-Parameters.instance.LockAngle));
        }
        else {
            References.instance.Player.transform.eulerAngles = new Vector3 (0, 0, Mathf.Clamp(References.instance.Player.transform.eulerAngles.z, 270+Parameters.instance.LockAngle, 360));
        }

        if (Input.GetKeyDown(KeyCode.Space)) {   

        }
        
    }

}

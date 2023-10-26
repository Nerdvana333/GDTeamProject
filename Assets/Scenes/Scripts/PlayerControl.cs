using UnityEngine;
using DG.Tweening;

public class PlayerControl : MonoBehaviour {

    void Update() {

        if (!Parameters.instance.Moveable) return; 
        rotateCharacter() ;
        

        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > GameState.instance.NextFire) {   

            fireTongue();

        }
        
    }

    private void rotateCharacter() {
    
        var movementH = Input.GetAxis("Horizontal");
        References.instance.Player.transform.Rotate (-1 * movementH * Parameters.instance.RotateSpeed * Time.deltaTime * Vector3.forward);

        if (References.instance.Player.transform.eulerAngles.z < 180) {
            References.instance.Player.transform.eulerAngles = new Vector3 (0, 0, Mathf.Clamp(References.instance.Player.transform.eulerAngles.z, 0, 90-Parameters.instance.LockAngle));
        }
        else {
            References.instance.Player.transform.eulerAngles = new Vector3 (0, 0, Mathf.Clamp(References.instance.Player.transform.eulerAngles.z, 270+Parameters.instance.LockAngle, 360));
        }
    
    }

    private void fireTongue() {

        GameState.instance.NextFire = Time.time + Parameters.instance.FireRate;
        var s = DOTween.Sequence();
        s.Append(References.instance.Tongue.transform.DOScaleY(Parameters.instance.TongueLength, Parameters.instance.TongueOutTime/2)).Append(References.instance.Tongue.transform.DOScaleY(0.5f, Parameters.instance.TongueOutTime/2));

    }

}

using UnityEngine;

public class Tongue : MonoBehaviour {
    private void OnTriggerEnter2D (Collider2D c) {

        if (!c.gameObject.CompareTag("Bug")) return;
        ScoreManager.instance.AddScore(c.gameObject.GetComponent<Bugs>().Score);

    }  

}

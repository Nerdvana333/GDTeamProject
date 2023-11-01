using UnityEngine;

public class Tongue : MonoBehaviour {
    public AudioClip clickSound; // 設置音效文件
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D (Collider2D c) {

        if (!c.gameObject.CompareTag("Bug")) return;
         if (audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
        ScoreManager.instance.AddScore(c.gameObject.GetComponent<Bugs>().Score);
        c.gameObject.GetComponent<Bugs>().killSuquence();
        HungerManager.instance.AddHunger(c.gameObject.GetComponent<Bugs>().Hunger);
        Destroy(c.gameObject);
        // Spwan new random bugs
        BugSpwaner spawner = FindObjectOfType<BugSpwaner>();
        if (spawner != null)
        {
            spawner.SpawnBug();
        }
    }  

}

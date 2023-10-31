using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager musicManager;

    public AudioSource MusicSource;

    public AudioClip MusicClip;   

    [Range( 0, 1 )]
    public float MusicVolume;

    private void Awake() {

        DontDestroyOnLoad (gameObject);

        if (musicManager == null) {
        musicManager = this;
        } else {
        Destroy(gameObject);
        }
    }
    void Start()
    {
        MusicSource.volume = 0.1f;
        MusicSource.PlayOneShot(MusicClip);
    }
}

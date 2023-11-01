using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioClip MusicClip1;
    public AudioClip MusicClip2;

    [Range(0, 1)]
    public float MusicVolume;

    private void Awake()
    {
        MusicSource.volume = MusicVolume;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Start()
    {
        // 在 Start 方法中播放音效
        MusicSource.PlayOneShot(MusicClip1);
        MusicSource.PlayOneShot(MusicClip2);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 每次場景載入時，重新設置音效
        MusicSource.Stop(); // 停止目前播放的音效
        // MusicSource.PlayOneShot(MusicClip); // 播放新的音效
    }
}

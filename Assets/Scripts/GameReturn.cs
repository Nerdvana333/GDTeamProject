using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameReturn : MonoBehaviour
{

    public AudioClip clickSound; // 設置音效文件
    private AudioSource audioSource;
    private bool isAudioPlaying = false;
    public Texture2D fingerCursor; // 這裡設定手指游標紋理
    void Start(){
        // 在 Start 函數中初始化 audioSource
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clickSound;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    void OnMouseEnter()
    {
        Cursor.SetCursor(fingerCursor, Vector2.zero, CursorMode.Auto);
    }
    void OnMouseExit()
    {
        // 在滑鼠離開物件時，將游標重設回默認游標（箭頭等）
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    private void OnMouseUpAsButton()
    {
        if (!isAudioPlaying)
        {
            PlayClickSound();
        }
    }
    void PlayClickSound()
    {
        // 在播放音效之前，檢查 audioSource 是否為 null
        if (audioSource != null)
        {
            audioSource.Play(); // 播放音效
            StartCoroutine(LoadNextSceneAfterSound());
        }
    }
    IEnumerator LoadNextSceneAfterSound()
    {
        // 在這裡添加一個緩衝時間以等待音效播放完畢
        float soundDuration = audioSource.clip.length;
        yield return new WaitForSeconds(soundDuration);

        // 被點擊時，載入遊戲主場景
        ReturnGame();
    }
    void ReturnGame()
    {
        SceneManager.LoadScene("GameStart"); 
    }
}

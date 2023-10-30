using UnityEngine;
using UnityEngine.SceneManagement;

public class GameNext : MonoBehaviour
{
    void Update()
    {
    }
    private void OnMouseDown()
    {
        // 被點擊時，載入遊戲主場景
        StartGame();
    }
    void StartGame()
    {
        SceneManager.LoadScene("Main scene 1"); // 換成您的遊戲主場景的名稱
    }
}

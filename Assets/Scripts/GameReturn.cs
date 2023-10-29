using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReturn : MonoBehaviour
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
        SceneManager.LoadScene("GameStart"); // 換成您的遊戲主場景的名稱
    }
}

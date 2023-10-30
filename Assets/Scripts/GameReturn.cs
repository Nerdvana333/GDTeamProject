using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReturn : MonoBehaviour
{
    void Update()
    {
    }
    private void OnMouseDown()
    {
  
        StartGame();
    }
    void StartGame()
    {
        SceneManager.LoadScene("GameStart"); 
    }
}

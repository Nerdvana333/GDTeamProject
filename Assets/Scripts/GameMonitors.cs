using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMonitors : MonoBehaviour {
 
    public static GameMonitors instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player State ------- ")]
    [SpaceAttribute(10)]
    [SerializeField] private float hunger;
    public float Hunger {

        get => hunger;
        set {
            hunger = value;
            if (hunger<0) {
                hunger = 0;
                LoadLose();
                // ... lose
            }
            if (hunger>1) hunger = 1;
        }
    }   

    [SerializeField] private int score;
    public int Score {

        get => score;
        set {
            score = value;
            if (score>100) {
                score = 100;
                LoadNextLevel();
                // ... win
            }
        }
    }

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    void Start() {

        hunger = 1f;
        score = 0;

    }
    void LoadNextLevel()
    {
        // do to Level
        // 
        Debug.Log("next level");
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == "Main scene")
        {
            
            SceneManager.LoadScene("Main scene 1");
        }
        else
        {
            
            SceneManager.LoadScene("WinGame");
        }
        
    }
    void LoadLose()
    {
        Debug.Log("Lose game");
        SceneManager.LoadScene("LoseGame");
    }

}

using UnityEngine;

public class ScoreManager: MonoBehaviour {

    public static ScoreManager instance;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }
    
    // void Update() {

    //     if (!GameState.instance.Playing) return;
        
    // }

    public void AddScore(int score) {
    
        GameMonitors.instance.Score += score;
        References.instance.ScorePanel.fillAmount = GameMonitors.instance.Score / 100f;
        UIManager.instance.UIAnimation(References.instance.ScoreUI, Parameters.instance.TextDeltaSize, Parameters.instance.BarScale, Parameters.instance.Duration);

    }

}

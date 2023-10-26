using UnityEngine;

public class ScoreManager: MonoBehaviour {

    public static ScoreManager instance;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    public void AddScore(int score) {
    
        GameMonitors.instance.Score += score;
        References.instance.ScorePanel.fillAmount = GameMonitors.instance.Score / 100f;
        UIManager.instance.UIAnimation(References.instance.ScoreUI, Parameters.instance.TextDeltaSize, Parameters.instance.BarScale, Parameters.instance.Duration);

    }

}

using UnityEngine;
using DG.Tweening;
using Text = TMPro.TextMeshProUGUI;


public class ScoreManager : MonoBehaviour {
    
    void Update() {

        if (GameSettings.instance.Playing) {
            // testing
            if (Input.GetKeyDown(KeyCode.Space)) {   
                
                GameMonitors.instance.Score += 10;
                References.instance.ScorePanel.fillAmount = GameMonitors.instance.Score / 100f;
                UIManager.instance.UIAnimation(References.instance.ScoreUI, Parameters.instance.TextSize, Parameters.instance.BarScale, Parameters.instance.Duration);

            }
        
        }
        
    }

}

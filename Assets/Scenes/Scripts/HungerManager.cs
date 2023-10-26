using UnityEngine;
using DG.Tweening;
using Text = TMPro.TextMeshProUGUI;


public class HungerManager : MonoBehaviour {
    
    void Update() {

        if (GameState.instance.Playing) {

            GameMonitors.instance.Hunger -= Time.deltaTime / Parameters.instance.GameTime;
            References.instance.HungerPanel.fillAmount = GameMonitors.instance.Hunger;
        
        }
        
    }

}

using UnityEngine;

public class HungerManager : MonoBehaviour {
    
    void Update() {

        if (GameSettings.instance.Playing) {

            GameMonitors.instance.Hunger -= Time.deltaTime / Parameters.instance.GameTime;
            References.instance.HungerPanel.fillAmount = GameMonitors.instance.Hunger;
        
        }
        
    }

}

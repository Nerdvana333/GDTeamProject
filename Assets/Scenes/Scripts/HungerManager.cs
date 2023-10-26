using UnityEngine;

public class HungerManager : MonoBehaviour {

    public static HungerManager instance;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }
    
    void Update() {

        if (!GameState.instance.Playing) return;
        DecreaseHunger();
  
    }

    private void DecreaseHunger() {
    
        GameMonitors.instance.Hunger -= Time.deltaTime / Parameters.instance.GameTime;
        References.instance.HungerPanel.fillAmount = GameMonitors.instance.Hunger;
    
    }

    public void AddHunger(float amount) {
    
        GameMonitors.instance.Hunger += amount / 100f;
        References.instance.HungerPanel.fillAmount = GameMonitors.instance.Hunger;
        UIManager.instance.UIAnimation(References.instance.HungerUI, Parameters.instance.TextDeltaSize, Parameters.instance.BarScale, Parameters.instance.Duration);
    
    }

}

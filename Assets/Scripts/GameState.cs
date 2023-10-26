using UnityEngine;

public class GameState : MonoBehaviour {

    public static GameState instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Game State ------- ")]
    [SpaceAttribute(10)]
    public bool Playing;
    public bool TongueOut;
    public float NextFire = 0.0f;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    void Start() {

        Cursor.visible = false; 

    }

}


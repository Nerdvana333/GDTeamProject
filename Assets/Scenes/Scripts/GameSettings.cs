using UnityEngine;

public class GameSettings : MonoBehaviour {

    public static GameSettings instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Game State ------- ")]
    [SpaceAttribute(10)]
    public bool Playing;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    void Start() {

        Cursor.visible = false; 

    }

}


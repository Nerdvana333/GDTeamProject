using UnityEngine;

public class Parameters : MonoBehaviour {
    public static Parameters instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player movement ------- ")]
    [SpaceAttribute(10)]
    public bool Moveable;
    public float RotateSpeed;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Game Time ------- ")]
    [SpaceAttribute(10)]
    public float GameTime;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }
    
}

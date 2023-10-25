using UnityEngine;

public class Parameters : MonoBehaviour {
    public static Parameters instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player movement ------- ")]
    [SpaceAttribute(10)]
    public bool Moveable;
    public float RotateSpeed;
    public float LockAngle;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Game Time ------- ")]
    [SpaceAttribute(10)]
    public float GameTime;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- UI Animation ------- ")]
    [SpaceAttribute(10)]
    public float TextSize;
    public float BarScale;
    public float Duration;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

}

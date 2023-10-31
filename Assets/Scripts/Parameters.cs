using Unity.VisualScripting.FullSerializer;
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
    public float TextDeltaSize;
    public float TextOriginalSize;
    public float BarScale;
    public float Duration;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- UI Animation ------- ")]
    [SpaceAttribute(10)]
    public float HungerSpeed;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Tongue Parameters ------- ")]
    [SpaceAttribute(10)]
    public float TongueLength;
    public float TongueOutTime;
    public float FireRate;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Bug Movement ------- ")]
    [SpaceAttribute(10)]
    public float BezierPointNumber;
    public float PathRandomOffset;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

}

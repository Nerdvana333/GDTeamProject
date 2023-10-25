using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMonitors : MonoBehaviour {
 
    public static GameMonitors instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player State ------- ")]
    [SpaceAttribute(10)]
    [SerializeField] private float hunger;
    public float Hunger {

        get => hunger;
        set {
            hunger = value;
            if (hunger<0) {
                hunger = 0;
                // ...
            }
        }
    }

    [SerializeField] private float Score;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    void Start() {

        hunger = 1f;

    }
 
}

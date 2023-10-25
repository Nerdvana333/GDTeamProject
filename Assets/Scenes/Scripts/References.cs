using UnityEngine;

public class References : MonoBehaviour {

    public static References instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player ------- ")]
    [SpaceAttribute(10)]
    public GameObject Player;



    void Awake() {
    
        if (instance == null) instance = this;
    
    }

}

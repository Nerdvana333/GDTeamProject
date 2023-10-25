using Shapes;
using UnityEngine;

public class References : MonoBehaviour {

    public static References instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player ------- ")]
    [SpaceAttribute(10)]
    public GameObject Player;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       -------  UI  ------- ")]
    [SpaceAttribute(10)]
    public IMPanelSample HungerPanel;
    public IMPanelSample ScorePanel;



    void Awake() {
    
        if (instance == null) instance = this;
    
    }

}

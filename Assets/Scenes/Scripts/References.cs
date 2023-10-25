using Shapes;
using UnityEngine;
using Text = TMPro.TextMeshProUGUI;

public class References : MonoBehaviour {

    public static References instance;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Player ------- ")]
    [SpaceAttribute(10)]
    public GameObject Player;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       -------  UI  ------- ")]
    [SpaceAttribute(10)]
    public GameObject HungerUI;
    public IMPanelSample HungerPanel;
    public Text HungerText;
    public GameObject ScoreUI;
    public IMPanelSample ScorePanel;
    public Text ScoreText;



    void Awake() {
    
        if (instance == null) instance = this;
    
    }

}

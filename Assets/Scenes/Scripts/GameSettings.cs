using UnityEngine;
using DG.Tweening;
using Text = TMPro.TextMeshProUGUI;

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

    // public void UIAnimation(GameObject obj, float textAmount, float scaleAmount, float time) {

    //     var s = DOTween.Sequence();
    //     Text t = obj.transform.GetChild(0).GetComponent<Text>();
    //     DOTween.To(x => t.fontSize = x, t.fontSize + textAmount, t.fontSize, time);
    //     s.Append(obj.transform.GetChild(1).transform.DOScale(scaleAmount, time/2)).Append(obj.transform.GetChild(1).transform.DOScale(1.65f, time/2));

    // }

}


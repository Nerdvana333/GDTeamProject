using UnityEngine;
using DG.Tweening;
using Text = TMPro.TextMeshProUGUI;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    public void UIAnimation(GameObject obj, float textAmount, float scaleAmount, float time) {

        var s = DOTween.Sequence();
        Text t = obj.transform.GetChild(0).GetComponent<Text>();
        //DOTween.To(x => t.fontSize = x, t.fontSize + textAmount, Parameters.instance.TextOriginalSize, time);
        DOTween.To(x => t.fontSize = x, Parameters.instance.TextOriginalSize + textAmount, Parameters.instance.TextOriginalSize, time);
        s.Append(obj.transform.GetChild(1).transform.DOScale(scaleAmount, time/2)).Append(obj.transform.GetChild(1).transform.DOScale(1.65f, time/2));

    }

}
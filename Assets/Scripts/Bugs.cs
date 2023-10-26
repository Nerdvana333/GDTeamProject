using UnityEngine;
using DG.Tweening;
using System.Collections;
using System.Linq;

public class Bugs : MonoBehaviour {

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Score gained ------- ")]
    [SpaceAttribute(10)]
    public int Score;
    public int Hunger;

    [SpaceAttribute(10)]
    [HeaderAttribute("                       ------- Path duration ------- ")]
    [SpaceAttribute(10)]
    public float PathDuration;

    private Sequence seq;

    void Start () {
    
        StartCoroutine(Move());

    }

    private IEnumerator Move() {

        while (true) {

            if (GameState.instance.Playing) {
                    
                Vector3[] pathTowards = BugsManager.instance.Bezier3Path(transform.GetChild(0).GetChild(0).position, transform.GetChild(0).GetChild(1).position, transform.GetChild(0).GetChild(2).position, transform.GetChild(0).GetChild(3).position, Parameters.instance.BezierPointNumber);
                Vector3[] pathBackwards = BugsManager.instance.Bezier3Path(transform.GetChild(0).GetChild(3).position, transform.GetChild(0).GetChild(2).position, transform.GetChild(0).GetChild(1).position, transform.GetChild(0).GetChild(0).position, Parameters.instance.BezierPointNumber);
                
                seq = DOTween.Sequence();
                seq.Append(this.transform.DOPath(pathTowards, PathDuration))
                .Append(this.transform.DOPath(pathBackwards, PathDuration));

                yield return new WaitForSeconds(PathDuration + 1);
                BugsManager.instance.ShiftMidPoint(this.transform);
                yield return new WaitForSeconds(PathDuration);

            }
            else {
            
                yield return new WaitForSeconds(1);

            }     

        }
        
    }

    public void killSuquence() {
    
        DOTween.Kill(seq);
        seq = null;
    
    }

}

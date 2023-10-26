using UnityEngine;

public class BugsManager : MonoBehaviour {

    public static BugsManager instance;

    void Awake() {
    
        if (instance == null) instance = this;
    
    }

    public  Vector3[] Bezier2Path(Vector3 startPos, Vector3 controlPos, Vector3 endPos, float pointNum) {
        Vector3[] path = new Vector3[(int)pointNum];
        for (int i = 1; i <= pointNum; i++) {
            float t = i / pointNum;
            path[i - 1] = Bezier2(startPos, controlPos, endPos, t);
        }
        // path[(int)pointNum] = endPos;
        return path;
    }

    public  Vector3[] Bezier3Path(Vector3 startPos, Vector3 controlPos1, Vector3 controlPos2, Vector3 endPos, float pointNum) {
        Vector3[] path = new Vector3[(int)pointNum];
        for (int i = 1; i <= pointNum; i++) {
            float t = i / pointNum;
            path[i - 1] = Bezier3(startPos, controlPos1, controlPos2, endPos, t);
        }
        //path[(int)pointNum] = endPos;
        return path;
    }

    private static Vector3 Bezier2(Vector3 startPos, Vector3 controlPos, Vector3 endPos, float t) {
        return (1 - t) * (1 - t) * startPos + 2 * t * (1 - t) * controlPos + t * t * endPos;
    }

    private static Vector3 Bezier3(Vector3 startPos, Vector3 controlPos1, Vector3 controlPos2, Vector3 endPos, float t) {
        float t2 = 1 - t;
        return t2 * t2 * t2 * startPos
            + 3 * t * t2 * t2 * controlPos1
            + 3 * t * t * t2 * controlPos2
            + t * t * t * endPos;
    }

    public void ShiftMidPoint(Transform obj) {
    
        obj.transform.GetChild(0).GetChild(1).position = new Vector3 (obj.transform.GetChild(0).GetChild(1).position.x + Random.Range( -1 * Parameters.instance.PathRandomOffset, Parameters.instance.PathRandomOffset), obj.transform.GetChild(0).GetChild(1).position.y + Random.Range( -1 * Parameters.instance.PathRandomOffset, Parameters.instance.PathRandomOffset), obj.transform.GetChild(0).GetChild(1).position.z);
        obj.transform.GetChild(0).GetChild(2).position = new Vector3 (obj.transform.GetChild(0).GetChild(2).position.x + Random.Range( -1 * Parameters.instance.PathRandomOffset, Parameters.instance.PathRandomOffset), obj.transform.GetChild(0).GetChild(2).position.y + Random.Range( -1 * Parameters.instance.PathRandomOffset, Parameters.instance.PathRandomOffset), obj.transform.GetChild(0).GetChild(2).position.z);
    
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpwaner : MonoBehaviour
{
    [SerializeField]GameObject[] bugPrefabs ;
    public void SpawnBug() {
        int r =  Random.Range(0, bugPrefabs.Length);
        GameObject bug = Instantiate(bugPrefabs[r], transform);
        bug.transform.position = new Vector3(
            Random.Range(-4f, 4f), // X
            Random.Range(-2, 2f), // Y
            0f ); 
    }
}

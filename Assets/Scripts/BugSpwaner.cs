using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BugSpwaner : MonoBehaviour
{
    [SerializeField]GameObject[] bugPrefabs ;
    public void SpawnBug() {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int r;
        if (currentSceneName == "Main scene")
        {
           r = Random.Range(0, bugPrefabs.Length-1);
        }
        else
        {
            r =  Random.Range(0, bugPrefabs.Length);
        }
       
        GameObject bug = Instantiate(bugPrefabs[r], transform);
        
        bug.transform.position = new Vector3(
        Random.Range(-4f, 4f), // X (relative position)
        Random.Range(-2, 2f), // Y
        0f ); 
    }
}

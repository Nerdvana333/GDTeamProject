using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInvisible : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool isVisible = true;
    public float toggleInterval = 1.0f; // 1 second

    private void Start()
    {
        Transform child = transform.Find("Character");
        objectRenderer = child.GetComponent<Renderer>();
        Debug.Log("toggleInterval");
        InvokeRepeating("ToggleVisibility", 0.0f, toggleInterval);
    }

    private void ToggleVisibility()
    {
        isVisible = !isVisible;
        objectRenderer.enabled = isVisible;
    }
}

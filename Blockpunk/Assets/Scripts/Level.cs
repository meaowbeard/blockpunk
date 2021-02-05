using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Params
    [SerializeField] int breakableBlocks; // Serialize for Debug

    // Cached References
    SceneLoader sceneloader;
    

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossPlatformPlayerSpawner : MonoBehaviour
{
    [SerializeField] private Text debugText;
    
    void Start()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsPlayer:
            case RuntimePlatform.WindowsEditor:
                Debug.Log("Project is running on : "+ Application.platform);
                debugText.text = "Project is running on : " + Application.platform;
                break;
            
            default:
                Debug.Log("project is running on : "+ Application.platform);
                debugText.text = "Project is running on : " + Application.platform;
                break;
        }
    }

    void Update()
    {
        
    }
}

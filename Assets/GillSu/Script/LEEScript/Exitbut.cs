using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Exitbut : MonoBehaviour
{
    
    public void ExitButton()
    {
        Debug.Log("dd");
        Application.Quit();
        EditorApplication.ExitPlaymode();
    }
    public void OptionClick()
    {
        OptionVolume ov = FindObjectOfType<OptionVolume>();
        ov.clickButton();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

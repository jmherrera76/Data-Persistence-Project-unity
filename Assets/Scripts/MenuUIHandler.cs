using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif

        GameManager.Instance.SaveRecord();
    }

    public void StartGame()
    {
        TMP_InputField inputField = GameObject.Find("userInputField").GetComponent<TMP_InputField>();

        GameManager.Instance.user = inputField.text;
        GameManager.Instance.actualScore = 0;
        GameManager.Instance.LoadRecord();
        SceneManager.LoadScene(1);  

    }



    public void GotoMenu()
    {
        SceneManager.LoadScene(1);

    }

    
}

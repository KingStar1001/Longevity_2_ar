using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;

    public TMP_InputField ageInput;
    public TMP_InputField weightInput;
    public TMP_InputField genderInput;

    public string age;
    public string weight;
    public string gender;

    void Awake(){
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart(){
        age = ageInput.text;
        weight = weightInput.text;
        gender = genderInput.text;

        SceneManager.LoadScene("vrtest");
    }
}

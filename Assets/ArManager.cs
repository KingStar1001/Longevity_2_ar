using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text ageText;
    public TMP_Text weightText;
    public TMP_Text genderText;
    void Start()
    {
        ageText.text = MainManager.instance.age;
        weightText.text = MainManager.instance.weight;
        genderText.text = MainManager.instance.gender;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

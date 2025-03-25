using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationPanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public TextMeshPro nameText;

    public TextMeshPro heightText;

    public TextMeshPro occupationText;

    public void UpdateText(string name, string height, string occupation)
    {
        nameText.text = name;
        heightText.text = height;
        occupationText.text = occupation;
    }
}

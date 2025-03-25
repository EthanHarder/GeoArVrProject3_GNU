using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingInformation : MonoBehaviour
{

    public string name = "TestName";

    public string height = "0m"; //metres 

    public string occupation = "";

    public string other = "";


    public InformationPanel panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendPanelInfo()
    {
        panel.UpdateText(name, height, occupation);
    }
}

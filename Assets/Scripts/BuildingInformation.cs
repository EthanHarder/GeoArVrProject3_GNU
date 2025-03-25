using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingInformation : MonoBehaviour
{

    public string name = "TestName";

    public string height = "0m"; //metres 

    public string occupation = "";

    public string other = "";

    public bool active;

    public MeshRenderer meshRenderer;

    public Material[] materials;

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


    public void UnHoverColor()
    {
        if (!active) meshRenderer.material = materials[0];
    }

    public void HoverColor()
    {
        if (!active) meshRenderer.material = materials[1];
    }

    public void SelectionColor()
    {
        meshRenderer.material = materials[1];
        active = true;
    }

    public void DeSelectColor()
    {
        active = false;
        meshRenderer.material = materials[0];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;


public class RayCasterController : MonoBehaviour
{

    public Material tMat;
    public Material hMat;
    public int rayLength = 10;
    public float delay = 0.05f;

    GameObject myLine;
    // Start is called before the first frame update
    void Start()
    {
        myLine = new GameObject();
        myLine.AddComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (OVRInput.Get(OVRInput.Button.One))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, rayLength * 10))
            {
                myLine.transform.position = transform.position;

                LineRenderer lr = myLine.GetComponent<LineRenderer>();
                
                
                

                lr.startWidth = 0.01f;
                lr.endWidth = 0.01f;
                lr.SetPosition(0, transform.position);
                lr.SetPosition(1, hit.point);
                
                

                if (hit.transform.gameObject.GetComponent<BuildingInformation>())
                {
                    lr.material = hMat;
                    hit.transform.gameObject.GetComponent<BuildingInformation>().SendPanelInfo();
                }
                else
                {
                    lr.material = tMat;
                }

            }
        }
        else
        {
            LineRenderer lr = myLine.GetComponent<LineRenderer>();




            lr.startWidth = 0.00f;
            lr.endWidth = 0.00f;
        }
    }
}

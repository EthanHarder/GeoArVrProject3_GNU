using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaler : MonoBehaviour
{


    public float min;
    public float max;

    bool doScale = false;

    bool increase = false;

    public void scaleUP()
    {
        doScale = true;
        increase = true;
    }

    public void scaleDown()
    {
        doScale = true;
        increase = false;
    }

    public void stop()
    {
        doScale=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doScale)
        {
            if (increase)
            {
                if (transform.localScale.x < max)
                    transform.localScale += new Vector3(1,1,1) * Time.deltaTime;
                
            }
            else
            {
                if (transform.localScale.x > min)
                    transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime;

            }
        }
    }
}

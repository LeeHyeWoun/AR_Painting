using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolOptionButtonController : MonoBehaviour {

    //initialization
    bool toggle_toolButton = false;
    bool pop = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (toggle_toolButton == true && pop == false)
        {
            transform.localPosition += new Vector3(0, 200, 0);
            toggle_toolButton = false;
            pop = true;
        }
        else if(toggle_toolButton == true && pop == true)
        {
            transform.localPosition -= new Vector3(0, 200, 0);
            toggle_toolButton = false;
            pop = false;
        }
    }

    public void toggle()
    {
        if(pop==false)
            toggle_toolButton = true;
    }
    public void notToggle()
    {
        if (pop == true)
            toggle_toolButton = true;
    }
}

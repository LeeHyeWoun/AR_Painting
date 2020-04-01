using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButtonController : MonoBehaviour {

    bool toggle = false;
    bool expand = false;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if(toggle == true)
        {
            if (expand == true)
                transform.localPosition -= new Vector3(0, 370, 0);
            else if (expand == false)
                transform.localPosition += new Vector3(0, 370, 0);
            toggle = false;
        }
    }

    public void toggle_OptionButton()
    {
        if (expand == false)
        {
            toggle = true;
            expand = true;
        }
        else
        {
            toggle = true;
            expand = false;
        }
    }
}

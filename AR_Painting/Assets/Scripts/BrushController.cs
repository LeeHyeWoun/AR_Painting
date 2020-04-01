using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrushController : MonoBehaviour {

    //color_materials
    public Material Mat01;
    public Material Mat02;
    public Material Mat03;

    //for Scrollbar.value
    public Scrollbar brushSize_slider;

    //initialization
    float brushSize = 0.8f;
    bool scroll = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scroll == true)
        {
            brushSize = 0.8f - brushSize_slider.value * 0.7f;
            transform.localScale = new Vector3(2, brushSize, 1);
        }
    }

    //Button_colorOption
    public void toggle_ColorOption_1()
    {
        gameObject.GetComponent<Renderer>().material = Mat01;
    }
    public void toggle_ColorOption_2()
    {
        gameObject.GetComponent<Renderer>().material = Mat02;
    }
    public void toggle_ColorOption_3()
    {
        gameObject.GetComponent<Renderer>().material = Mat03;
    }

    //ScrollBar_sizeOption
    public void Scroll_start()
    {
        scroll = true;
    }
    public void Scroll_end()
    {
        scroll = false;
    }

}

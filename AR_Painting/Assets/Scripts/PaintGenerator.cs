using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintGenerator : MonoBehaviour {

    //for Scrollbar.value
    public Scrollbar paintSize_slider;
 //   public GameObject box;

    //color_prefabs
    public GameObject Paint01;
    public GameObject Paint02;
    public GameObject Paint03;

    //Object Variable
    GameObject Paint;
//    Vector3 Paint_Position;

    //initialization
    float paintSize = 0.8f;
    int colorOption = 1;
    int clear_size = 5;
    string cloneName = "color_red(Clone)";
    bool draw = false;
    bool allClear = false;
    bool Clear = false;

    // Update is called once per frame
    void Update () {

        paintSize = 0.8f - paintSize_slider.value * 0.7f;
//        Paint_Position = box.transform.position;
        if (draw == true)
        {
            switch (colorOption)
            {
                case 1:
                    cloneName = "color_red(Clone)";
                    Paint = Paint01;
                    break;

                case 2:
                    cloneName = "color_yellow(Clone)";
                    Paint = Paint02;
                    break;

                case 3:
                    cloneName = "color_green(Clone)";
                    Paint = Paint03;
                    break;
            }
            Paint.transform.localScale = new Vector3(paintSize, paintSize, 1);
            Instantiate(Paint, transform.position, transform.rotation);
        }
        else if (Clear == true)
        {
            if (GameObject.Find(cloneName) != null)
                Destroy(GameObject.Find(cloneName));

            if (GameObject.Find(cloneName) != null && clear_size > 0)
                clear_size--;
            else
            {
                Clear = false;
                clear_size = 5;
            }

        }
        else if (allClear == true)
        {
            if (GameObject.Find("color_red(Clone)") != null)
                Destroy(GameObject.Find("color_red(Clone)"));
            else if(GameObject.Find("color_yellow(Clone)") != null)
                Destroy(GameObject.Find("color_yellow(Clone)"));
            else if (GameObject.Find("color_green(Clone)") != null)
                Destroy(GameObject.Find("color_green(Clone)"));
            else
                allClear = false;
        }
    }

    //Button_color_Option
    public void toggle_ColorOption_1() {
        colorOption = 1;
    }
    public void toggle_ColorOption_2()
    {
        colorOption = 2;
    }
    public void toggle_ColorOption_3()
    {
        colorOption = 3;
    }

    //Button_Draw
    public void Draw_start() {
        draw = true;
    }
    public void Draw_stop()
    {
        draw = false;
    }

    //Button_AllClear
    public void All_clear()
    {
        allClear = true;
    }

    //Button_Clear
    public void clear()
    {
        Clear = true;
    }

}

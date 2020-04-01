using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintParticleGenerator : MonoBehaviour {

    //for Scrollbar.value
    public Scrollbar paintSize_slider;

    //color_prefabs
    public GameObject Particle01;
    public GameObject Particle02;
    public GameObject Particle03;
    public GameObject Particle04;

    //Object Variable
    GameObject Particle;

    //initialization
    float paintSize = 0.8f;
    int colorOption = 1;
    bool draw = false;
	
	// Update is called once per frame
	void Update () {

        paintSize = 0.8f - paintSize_slider.value * 0.7f;

        //If you hold Button_Draw
        if (draw == true)
        {
            //If you select Button_color_Option
            switch (colorOption)
            {
                case 1:
                    Particle = Particle01;
                    break;

                case 2:
                    Particle = Particle02;
                    break;

                case 3:
                    Particle = Particle03;
                    break;

                case 4:
                    Particle = Particle04;
                    break;
            }
            //Create a particle, delete it after 2 seconds
            Particle.transform.localScale = new Vector3(paintSize, paintSize, 1);
            Instantiate(Particle, transform.position, transform.rotation);
        }
    }

    //Button_color_Option
    public void toggle_ColorOption_1()
    {
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

    //Button_glitter
    public void toggle_glitterOption()
    {
        colorOption = 4;
    }


    //Button_Draw
    public void Draw_start()
    {
        draw = true;
        GetComponent<AudioSource>().Play();
    }
    public void Draw_stop()
    {
        draw = false;
        GetComponent<AudioSource>().Stop();
    }

}

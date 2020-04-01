using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject,4f);

    }

    // Update is called once per frame
    void Update () {
	}

    public void AppStart()
    {
        Destroy(this.gameObject);
    }
}

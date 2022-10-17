using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb;

    // Use this for initialization
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        cube.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
        Debug.Log("Button pressed");
    }
}

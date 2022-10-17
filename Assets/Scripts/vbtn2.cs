using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtn2 : MonoBehaviour
{
    public VirtualButtonBehaviour Vb;
    public Animator cubeAnim;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAnim.Play("CubeAnim");
        Debug.Log("Button pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

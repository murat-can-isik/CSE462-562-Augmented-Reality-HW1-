using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class sphere_anim : MonoBehaviour
{
 
    public GameObject vbBtnObj;
    public Animator sphereAni;
 
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Spherebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
        sphereAni.GetComponent<Animator>();
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sphereAni.Play("sphere_animation");
        Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        sphereAni.Play("none");
        Debug.Log("Button released");
    }
}
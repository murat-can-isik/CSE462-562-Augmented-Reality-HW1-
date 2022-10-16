using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class selection_cube : MonoBehaviour
{
 
    public GameObject cubeBtnObj;
    public Animator selectCubeAni;
 
    // Use this for initialization
    void Start()
    {
        cubeBtnObj = GameObject.Find("Cubebtn");
        cubeBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        cubeBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
 
        selectCubeAni.GetComponent<Animator>();
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        selectCubeAni.Play("select_cube");
        Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        selectCubeAni.Play("none");
        Debug.Log("Button released");
    }
}
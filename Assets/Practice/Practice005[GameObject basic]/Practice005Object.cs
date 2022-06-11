using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice005Object : MonoBehaviour
{
    // Update is called once per frame
    private void Awake()
    {
        Debug.Log("Awake");
    }
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start");
    }
    // Update is called once per frame
    private void Update()
    {
        Debug.Log("Update");
    }
    // Fixed Update is called once per every fixed framerate frame
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }
}

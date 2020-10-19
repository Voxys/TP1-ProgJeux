﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GetShipCore : MonoBehaviour
{
    [SerializeField]
    GameObject UI;
    static bool hasShipCore { get; set; }

    private void Start()
    {
        UI.SetActive(false);
        hasShipCore = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && UI.activeInHierarchy)
        {
            //this.gameObject.SetActive(false);
            hasShipCore = true;
        }

        //Debug.Log(hasShipCore);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Default"))
        {
            UI.SetActive(true);
        }      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.SetActive(false);
    }

    public bool GetShipCoreState() 
    {
        return hasShipCore;
    }
}

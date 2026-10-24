using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    public SelectableScript[] selectables;
    public SelectableScript selectedObject;

    public SelectableScript highlighted;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectables = GameObject.FindObjectsByType<SelectableScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAttack()
    {
        if(highlighted != null)
        {
            highlighted.select();
            selectedObject = highlighted;
        }
        else
        {
            selectedObject?.deselect();
            selectedObject = null;
            
        }
    }
}

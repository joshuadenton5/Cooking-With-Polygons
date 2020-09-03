﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell //dictates a position where items can be placed 
{
    private Vector3 position;
    private bool isTaken;
    public List<GenericInteraction> interactions = new List<GenericInteraction>();

    public void SetPosition(Vector3 pos)
    {
        position = pos;    
    }

    public void SetOccupied(bool taken)
    {
        isTaken = taken;
    }

    public bool Taken()
    {
        return isTaken;
    }

    public Vector3 Position()
    {
        return position;
    }
}

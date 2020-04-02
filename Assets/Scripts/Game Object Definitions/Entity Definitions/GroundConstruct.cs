﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Constructs on the ground
/// </summary>
public class GroundConstruct : Construct
{
    protected override void Start()
    {
        Terrain = TerrainType.Ground;
        base.Start();
    }

    protected override void Update ()
    {
        base.Update();
	}
}

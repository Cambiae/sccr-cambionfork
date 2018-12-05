﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMeter : MonoBehaviour {

	public static void AddDataPoint(float data)
    {
        if (instance)
            instance.addDataPoint(data);
    }

    private void addDataPoint(float data)
    {
        renderer.SetPosition(index, new Vector3(step * index, data / 100f, 0f));
        index = (index + 1) % pointCount;
    }

    static DebugMeter instance;

    //float[] data = new float[1024];
    int index = 0;
    new LineRenderer renderer;
    int pointCount = 1024;
    float step = 0.1f;

    private void Awake()
    {
        instance = this;
        renderer = gameObject.AddComponent<LineRenderer>();
        renderer.positionCount = pointCount;
        //for(int i = 0; i < pointCount; i++)
        //{
        //    data[i] = 0f;
        //}
        renderer.startColor = Color.green;
        renderer.endColor = Color.green;
        renderer.startWidth = 0.1f;
        renderer.endWidth = 0.1f;
        renderer.useWorldSpace = true;

        step = 5f / pointCount;
        for (int i = 0; i < pointCount; i++)
        {
            renderer.SetPosition(i, new Vector3(step * i, 0f, 0f));
        }
    }
}

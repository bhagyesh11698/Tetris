﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Spawner : MonoBehaviour
{
    public Shape[] m_allShapes;

    Shape GetRandomShape()
    {
        int i = Random.Range(0, m_allShapes.Length);
        if (m_allShapes[i])
        {
            return m_allShapes[i];
        }
        else
        {
            Debug.Log("Invalid Shape");
            return null;
        }
    }

    public Shape SpawnShape()
    {
        Shape shape = null;
        shape = Instantiate(GetRandomShape(), transform.position, Quaternion.identity) as Shape;

        if (shape)
        {
            return shape;
        }
        else
        {
            Debug.Log("Invalid shape in spawner");
            return null;
        }
    }

    private void Start()
    {
        Vector2 originalVector = new Vector2(4.3f, 1.3f);
        Vector2 newVector = Vectorf.Round(originalVector);
    }

}

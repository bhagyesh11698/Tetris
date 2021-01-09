﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class Board : MonoBehaviour
{
    public Transform m_emptySrite;
    public int m_height = 30;
    public int m_width = 10;

    public int m_header = 8;

    Transform[,] m_grid;

    private void Awake()
    {
        m_grid = new Transform[m_width, m_height];

    }

    private void Start()
    {
        DrawEmptyCells();
    }

    void DrawEmptyCells()
    {
        if (m_emptySrite)
        {

            for (int y = 0; y < m_height - m_header; y++)
            {
                for (int x = 0; x < m_width; x++)
                {
                    Transform clone;
                    clone = Instantiate(m_emptySrite, new Vector3(x, y, 0), Quaternion.identity) as Transform;
                    clone.name = "Board Space (x= " + x.ToString() + ", y=" + y.ToString() + ")";
                    clone.transform.parent = transform;
                }
            }
        }
        else
        {
            Debug.Log("Assing Empty Sprite");
        }
    }


}

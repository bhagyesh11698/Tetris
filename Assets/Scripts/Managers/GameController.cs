using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour
{
    Board m_gameBoard;
    Spawner m_spawner;

    // currently active shape
    Shape m_activeShape;

    float m_dropInterval = 1f;

    float m_timeToDrop;

    private void Start()
    {
        //Method 1
        m_gameBoard = GameObject.FindGameObjectWithTag("Board").GetComponent<Board>();
        m_spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();

        //Method 2 - FindObject of type is slower
        //m_gameBoard = GameObject.FindObjectOfType<Board>();
        //m_spawner = GameObject.FindObjectOfType<Spawner>();

        //Method 3
        //m_gameBoard = GameObject.FindObjectOfType(typeof(Board)) as Board;

        if (!m_gameBoard)
        {
            Debug.LogWarning("Board Not Found");
        }
        if (!m_spawner)
        {
            Debug.LogWarning("Spawer Not Found");
        }

        if (m_spawner)
        {
            if (m_activeShape == null)
            {
                m_activeShape = m_spawner.SpawnShape();
            }
            m_spawner.transform.position = Vectorf.Round(m_spawner.transform.position);
        }
    }

    private void Update()
    {
        if (!m_gameBoard || !m_spawner)
        {
            return;
        }

        if (Time.time > m_timeToDrop)
        {
            m_timeToDrop = Time.time + m_dropInterval;
            if (m_activeShape)
            {
                m_activeShape.MoveDown();

                if (!m_gameBoard.IsValidPosition(m_activeShape))
                {
                    //Shape Landing
                    m_activeShape.MoveUp();
                    m_gameBoard.StoreShapeInGrid(m_activeShape);

                    if (m_spawner)
                    {
                        m_activeShape = m_spawner.SpawnShape();
                    }
                }
            }
        }
    }


}

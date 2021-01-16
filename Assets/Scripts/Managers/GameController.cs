using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour
{
    Board m_gameBoard;
    Spawner m_spawner;

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
            m_spawner.transform.position = Vectorf.Round(m_spawner.transform.position);
        }
    }


}

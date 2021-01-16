using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Shape : MonoBehaviour
{
    public bool m_canRotate;

    #region Move
    private void Move(Vector3 moveDirection)
    {
        transform.position += moveDirection;
    }

    public void MoveLeft()
    {
        Move(new Vector3(-1, 0, 0));
    }
    public void MoveRight()
    {
        Move(new Vector3(1, 0, 0));

    }
    public void MoveDown()
    {
        Move(new Vector3(0, -1, 0));

    }
    public void MoveUp()
    {
        Move(new Vector3(0, 1, 0));

    }
    #endregion Move

    #region Rotate
    public void RotateRight()
    {
        if (m_canRotate)
        {
            transform.Rotate(0, 0, -90);
        }
    }

    public void RotateLeft()
    {
        if (m_canRotate)
        {
            transform.Rotate(0, 0, 90);
        }
    }
    #endregion Rotate

    private void Start()
    {
        //InvokeRepeating("MoveDown", 0, 0.5f); // Moves down after every 0.5 seconds
        //InvokeRepeating("RotateLeft", 0, 2f); // Moves down after every 2 seconds
    }
}

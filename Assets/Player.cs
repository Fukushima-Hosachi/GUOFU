using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public void MoveUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f);
    }
    public void MoveDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f);
    }
    public void MoveLeft()
    {
        transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y);
    }
    public void MoveRight()
    {
        transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y);
    }
}
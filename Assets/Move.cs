using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public void MoveLeft(float Speed = 5f)
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }

    public void MoveRight(float Speed = 5f)
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlatformControlls : MonoBehaviour
{
    public PlatformCreation PlatformCreation;

    public float speed = 5f;
    private Rigidbody rb;

    public int GetWhichPlatform()
    {
        //-1 because the first index is 0 and -4 because the program starts with 4 clones
        return (PlatformCreation.ClonedPlatforms.Count - 4);
    }

    public void MoveLeft()
    {
        GameObject Platform = PlatformCreation.ClonedPlatforms[GetWhichPlatform()];
        Platform.GetComponent<Move>().MoveLeft();
    }

    public void MoveRight()
    {
        GameObject Platform = PlatformCreation.ClonedPlatforms[GetWhichPlatform()];
        Platform.GetComponent<Move>().MoveRight();
    }
}

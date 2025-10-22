using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCreation : MonoBehaviour
{
    public GameObject Background;
    public GameObject FirstBackground;
    public List<GameObject> ClonedBackgrounds;

    float Xposition = 0.027f;
    float Yposition = 26.12f;
    float DifferentsBetweenBackgroundHeights = 20.78f;

    public void CloneObject()
    {
        GameObject clone = Instantiate(Background, new Vector2(Xposition, Yposition), Quaternion.Euler(0f, 0f, 90f));
        ClonedBackgrounds.Add(clone);
        Yposition += DifferentsBetweenBackgroundHeights;
    }

    public void ReachedNextHeight()
    {
        if(ClonedBackgrounds.Count > 0)
        {
            ClonedBackgrounds[(ClonedBackgrounds.Count - 1)].tag = "Nothing";
        }
        else
        {
            FirstBackground.tag = "Nothing";
        }
        CloneObject();
    }
}

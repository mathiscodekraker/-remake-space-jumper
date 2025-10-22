using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class PlatformCreation : MonoBehaviour
{
    public GameObject PlatformNoSpikes;
    public GameObject PlatformLeftSpikes;
    public GameObject PlatformRightSpikes;
    public GameObject PlatformMiddleSpikes;
    public GameObject PlatformLeftAndRightSpikes;
    private List<GameObject> PlatformList;

    public List<GameObject> ClonedPlatforms;

    private float PlatformHeight = -2.5f;
    private float DifferentsBetweenPlatformHeights = 2f;

    private int AmountOfStarterClones = 4;

    private float ReturnXposition()
    {
        bool XpositionLeft = (UnityEngine.Random.value > 0.5f);
        float Xposition = (XpositionLeft) ? -3f : 3.4f;
        return Xposition;
    }

    private GameObject ReturnPlatform()
    {
        int WhichPlatform = UnityEngine.Random.Range(0, 4);
        return PlatformList[WhichPlatform];
    }

    public void CloneObject()
    {
        float Xposition = ReturnXposition();
        GameObject clone = Instantiate(ReturnPlatform(), new Vector2(Xposition, PlatformHeight), Quaternion.identity);
        ClonedPlatforms.Add(clone);
        PlatformHeight += DifferentsBetweenPlatformHeights;
    }

    public void ReachedNextHeight()
    {
        ClonedPlatforms[(ClonedPlatforms.Count - AmountOfStarterClones)].GetComponent<ExternalAlterations>().ChangeNextLineTag();
        CloneObject();
    }

    //______________________________________________________________________________________________________________________________________________________________

    // Start is called before the first frame update
    void Start()
    {
        PlatformList = new List<GameObject> { PlatformNoSpikes, PlatformLeftSpikes, PlatformRightSpikes, PlatformMiddleSpikes, PlatformLeftAndRightSpikes };
        int i = 0;
        while (i < AmountOfStarterClones)
        {
            CloneObject();
            i++;
        }
    }
}

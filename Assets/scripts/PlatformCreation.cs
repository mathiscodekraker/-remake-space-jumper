using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlatformCreation : MonoBehaviour
{
    public GameObject Player;

    public GameObject PlatformNoSpikes;
    public GameObject PlatformLeftSpikes;
    public GameObject PlatformRightSpikes;
    public GameObject PlatformMiddleSpikes;
    public GameObject PlatformLeftAndRightSpikes;
    private List<GameObject> PlatformList;

    public List<GameObject> ClonedPlatforms;

    private float PlatformHeight = -1f;
    private float DifferentsBetweenPlatformHeights = 2f;

    private float BallCurrentHeight = -0.8686101f;
    private float BallNextLevelHeight;
    private float BallDifferents = 3f;
    private float BallLowestHeight;

    private bool StartPositionNotYetReached;

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

    //______________________________________________________________________________________________________________________________________________________________

    // Start is called before the first frame update
    void Start()
    {
        BallNextLevelHeight = BallCurrentHeight + BallDifferents;
        PlatformList = new List<GameObject> { PlatformNoSpikes, PlatformLeftSpikes, PlatformRightSpikes, PlatformMiddleSpikes, PlatformLeftAndRightSpikes };
        CloneObject();
        CloneObject();
        CloneObject();
        CloneObject();
        StartPositionNotYetReached = true;
        BallLowestHeight = Player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        BallCurrentHeight = Player.transform.position.y;
        while (StartPositionNotYetReached)
        {
            if(BallCurrentHeight < (BallDifferents + BallLowestHeight))
            {
                StartPositionNotYetReached = false;
            }
        }
        if (BallCurrentHeight > BallNextLevelHeight)
        {
            BallNextLevelHeight += BallDifferents;
            BallCurrentHeight += BallDifferents;
            CloneObject();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalAlterations : MonoBehaviour
{
    public void ChangeNextLineTag()
    {
        GameObject NextLine = transform.Find("NextLine").gameObject;
        NextLine.tag = "Nothing";
        NextLine.transform.position += new Vector3(0, -4, 0);
        StartCoroutine(SetNextLineTagLater(NextLine, 0.1f));
    }

    private IEnumerator SetNextLineTagLater(GameObject nextLine, float delay)
    {
        yield return new WaitForSeconds(delay);
        nextLine.tag = "Spikes";
    }
}

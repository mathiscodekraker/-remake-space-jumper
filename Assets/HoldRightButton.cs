using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class HoldRightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnHold;
    private bool isHolding = false;

    void FixedUpdate()
    {
        if (isHolding && OnHold != null)
        {
            OnHold.Invoke(); // roept alle functies aan die je in de Inspector hebt toegevoegd
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHolding = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHolding = false;
    }
}

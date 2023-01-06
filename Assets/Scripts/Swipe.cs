using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 IneitailswipePostion;
    private float distanceMoved;
    public bool swipeleft;
    public bool swiperight;
    

    public void OnDrag (PointerEventData eventData)
    {
        transform.localPosition = new Vector2( transform.localPosition.x + eventData.delta.x, transform.localPosition.y );
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        IneitailswipePostion= transform.localPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        distanceMoved= Mathf.Abs(transform.localPosition.x - IneitailswipePostion.x );
        if(distanceMoved < 0.4 * Screen.width)
        {
            transform.localPosition = IneitailswipePostion;
        }
        else
        {
            if(transform.position.x > IneitailswipePostion.x)
            {
                swipeleft= true;
            }
            else
            {
                swiperight = true;
            }
        }
    }

    public void    Update ()
    {
        if(swipeleft == true)
        {
            Destroy(gameObject);
            swipeleft = false;
        }
        if(swiperight == true)
        {
            Destroy(gameObject);
            swiperight = false;
        }
    }

    
}

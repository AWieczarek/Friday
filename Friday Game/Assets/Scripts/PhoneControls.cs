using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneControls : MonoBehaviour
{
    public Beer beer;
    void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touchPosition.x > 0)
            {
                beer.BeerValue += 1;
                beer.isDrinkingBeer = true;
            }
            else
            {
                beer.BeerZeroValue += 1;
                beer.isDrinkingBeerZero = true;
            }
        }
        
    }
}

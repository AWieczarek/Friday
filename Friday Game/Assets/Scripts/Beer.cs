using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour
{
    public double BeerValue = 0;
    public double BeerZeroValue = 0;
    public int NumberOfBeers = 0;
    public int NumberOfBeersZero = 0;
    public int x, y;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            BeerValue += 0.01;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            BeerZeroValue += 0.1;
        }

        if(BeerValue > x)
        {

            x++;
		}

        if(BeerZeroValue > y)
        {

            y++;
		}
        
        if(BeerValue >= 100)
        {
            NumberOfBeers++;
            BeerValue = 0;
            x = 1;

		}

        if(BeerZeroValue >= 100)
        {
            NumberOfBeersZero++;
            BeerZeroValue = 0;
            y = 1;
            BeerValue += 5;

		}
    }

}

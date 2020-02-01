using UnityEngine;
using UnityEngine.UI;

public class BeerBar : MonoBehaviour
{
    public Image CurentBeer;
    public Beer beer;
    public int x = 1;

    public double maxBeerValue = 100;

    void Start()
    {
        UpdateBeerBar();
    }

    void Update()
    {
        if (beer.BeerValue > x)
        {
            UpdateBeerBar();
            x++;
        }

        if (beer.BeerValue >= 99)
        {
            x = 1;
            UpdateBeerBar();
        }
    }

    // Update is called once per frame
    void UpdateBeerBar()
    {
        double ratio = beer.BeerValue / maxBeerValue;
        CurentBeer.rectTransform.localScale = new Vector3((float)ratio, 1, 1);
    }
}

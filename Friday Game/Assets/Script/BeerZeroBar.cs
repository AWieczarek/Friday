using UnityEngine;
using UnityEngine.UI;

public class BeerZeroBar : MonoBehaviour
{
    public Image CurentBeerZero;
    public Beer beer;
    public int x = 1;

    public double maxBeerZeroValue = 100;

    void Start()
    {
        UpdateBeerZeroBar();
    }

    void Update()
    {
        if (beer.BeerZeroValue > x)
        {
            UpdateBeerZeroBar();
            x++;
        }

        if (beer.BeerZeroValue >= 99)
        {
            x = 1;
            UpdateBeerZeroBar();
        }
    }

    // Update is called once per frame
    void UpdateBeerZeroBar()
    {
        double ratio = beer.BeerZeroValue / maxBeerZeroValue;
        CurentBeerZero.rectTransform.localScale = new Vector3((float)ratio, 1, 1);
    }
}

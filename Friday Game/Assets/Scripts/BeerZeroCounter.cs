using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeerZeroCounter : MonoBehaviour
{
    public GameObject manager;
    public TextMeshProUGUI beerZeroCounter;

    void Start()
    {
        beerZeroCounter = GetComponent<TextMeshProUGUI>();
        manager = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        beerZeroCounter.text = manager.GetComponent<Beer>().NumberOfBeersZero.ToString();
    }
}

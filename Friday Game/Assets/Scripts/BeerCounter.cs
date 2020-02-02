using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeerCounter : MonoBehaviour
{
    public GameObject manager;
    public TextMeshProUGUI beerCounter;

    void Start()
    {
        beerCounter = GetComponent<TextMeshProUGUI>();
        manager = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        beerCounter.text = manager.GetComponent<Beer>().NumberOfBeers.ToString();
    }
}

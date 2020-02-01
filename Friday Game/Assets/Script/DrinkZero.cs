using UnityEngine;
using UnityEngine.UI;
public class DrinkZero : MonoBehaviour
{
    public GameObject obj;
    public Text beerZeroValueText;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
    }
    // Update is called once per frame
    void Update()
    {
        beerZeroValueText.text = obj.GetComponent<Beer>().BeerZeroValue.ToString("0") + "%";
    }
}
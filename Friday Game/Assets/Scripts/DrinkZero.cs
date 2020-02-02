using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DrinkZero : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI beerZero_Score;

    private void Awake()
    {

        beerZero_Score = GetComponent<TextMeshProUGUI>();

        obj = GameObject.FindGameObjectWithTag("GameController");
    }
    // Update is called once per frame
    void Update()
    {
        beerZero_Score.text = obj.GetComponent<Beer>().BeerZeroValue.ToString("0") + "%";
    }
}

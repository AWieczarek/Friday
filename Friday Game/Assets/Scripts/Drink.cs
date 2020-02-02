using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Drink : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI beer_Score;

    private void Awake()
    {

            beer_Score = GetComponent<TextMeshProUGUI>();

            obj = GameObject.FindGameObjectWithTag("GameController");
    }
    // Update is called once per frame
    void Update()
    {
        beer_Score.text = obj.GetComponent<Beer>().BeerValue.ToString("0") + "%";
    }
}

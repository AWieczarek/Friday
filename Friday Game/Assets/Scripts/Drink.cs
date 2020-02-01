using UnityEngine;
using UnityEngine.UI;
public class Drink : MonoBehaviour
{
    public GameObject obj;
    public Text beerValueText;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
    }
    // Update is called once per frame
    void Update()
    {
        beerValueText.text = obj.GetComponent<Beer>().BeerValue.ToString("0") + "%";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject obj;
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
        animator.SetBool("IsDrinkingBeer", obj.GetComponent<Beer>().isDrinkingBeer);
        animator.SetBool("IsDrinkingBeerZero", obj.GetComponent<Beer>().isDrinkingBeerZero);
    }
}

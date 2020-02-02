using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Animator : MonoBehaviour
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

        animator.SetBool("IsDoorOpen", obj.GetComponent<Beer>().isDoorOpen);
    }
}

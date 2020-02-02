using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentsEnter : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;
    public bool parents = false;
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if(obj.GetComponent<Beer>().isDoorOpen)
        {
            obj1.SetActive(true);
            parents = true;
        }
        else
        {
            obj1.SetActive(false);
            parents = false;
        }
    }
}

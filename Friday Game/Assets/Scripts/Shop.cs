using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject obj;
    public bool shop = false;

    void Start()
    {
    }

    void Update()
    {
        if(shop)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }

    public void OpenShop(){
        if(!shop)
        {
            shop = true;  
		}
        else
        {
            shop = false;  
		}
	}

    public void Kupa()
    {
     Debug.Log("Kupa");
	}
}

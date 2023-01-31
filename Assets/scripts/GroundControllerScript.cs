using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControllerScript : MonoBehaviour
{
    
  
    void Update()
    {
        if (Camera.main.transform.position.y > (transform.position.y + 8.0f))
        {
            GroundSpawner.Instance.spowennewGround();
           this.gameObject.SetActive(false);//disble ground
        }
    }
}//class

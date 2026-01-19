using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTrans;

    private void Update()
    {
        if(PlayerTrans.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, PlayerTrans.position.y, transform.position.z);
        }
        
        
    }
}

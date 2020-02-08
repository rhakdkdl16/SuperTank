using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    Transform tr;
    private void Awake()
    {
        tr = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Transform>();
        
    }
    private void LateUpdate()
    {
        Vector3 Pos;
        Pos = Camera.main.WorldToScreenPoint(tr.position);
        gameObject.transform.position = new Vector3(Pos.x,Pos.y + 60 , Pos.z);
    }
}

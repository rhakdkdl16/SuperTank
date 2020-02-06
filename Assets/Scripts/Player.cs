using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    RectTransform canvas;
    Transform tr;
    private void Awake()
    {
        tr = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Transform>();
        
    }
    private void LateUpdate()
    {
        Vector3 Pos;
        Pos = Camera.main.WorldToScreenPoint(tr.position);
        //RectTransformUtility.ScreenPointToWorldPointInRectangle(canvas,)
        gameObject.transform.position = new Vector3(Pos.x,Pos.y + 60 , Pos.z);
    }
}

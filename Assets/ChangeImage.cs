using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour {

     public Sprite red;
	 SpriteRenderer spr  = null;
 
     void Start ()
     {
         spr = GetComponent<SpriteRenderer>();
     }
     
     void OnMouseDown() 
     {
             ColorChangered();
     }
     void ColorChangered() 
     {
         spr.sprite = red;
     }
}

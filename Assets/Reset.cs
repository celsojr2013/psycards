using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Reset : MonoBehaviour, IPointerClickHandler {

public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
        }

        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {

		 Application.LoadLevel(Application.loadedLevel);
        }
    }



public void resetGame()
{
    Application.LoadLevel(Application.loadedLevel);
}

}
//Attatch this script to a Button GameObject
using UnityEngine;
using UnityEngine.EventSystems;

public class Turn : MonoBehaviour, IPointerClickHandler
{
    //Detect if a click occurs

	Transform first = null;
	Transform second = null;
    public bool Turnable = true;

    Shuffler shu = null;

	int idx1 = 0;
	
	int idx2 = 0;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
        }

        if (pointerEventData.button == PointerEventData.InputButton.Left)
        {

            if(Turnable)
            {
                turn();
                Turnable = false;
 
            }
        }
    }

    public void turn()
    {
            shu = this.transform.GetComponent<Shuffler>();
            shu.Turn();       
    }
}

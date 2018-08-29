using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public int MaxCards = 0;
	public string[] Hand;

	public void OnPointerEnter(PointerEventData eventData) {
		if(eventData.pointerDrag==null || this.transform.childCount >= MaxCards)
			return;

		Dragable d =eventData.pointerDrag.GetComponent<Dragable>();
		if(d!=null){
			d.placeholderParent = this.transform;
		}

	}
	public void OnPointerExit(PointerEventData eventData) {
		if(eventData.pointerDrag==null  || this.transform.childCount >= MaxCards)
			return;

		Dragable d =eventData.pointerDrag.GetComponent<Dragable>();
		if(d != null && d.placeholderParent == this.transform){
			d.placeholderParent = d.parentToReturnTo;
		}
	}


	public void OnDrop(PointerEventData eventData) {
		Dragable d = eventData.pointerDrag.GetComponent<Dragable>();
		if(d!=null){
			d.parentToReturnTo = this.transform;
			Hand[d.placeholder.transform.GetSiblingIndex()] = d.imagename;
		}
	}

}

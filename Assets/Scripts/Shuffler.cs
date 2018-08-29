using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shuffler : MonoBehaviour {
	public Sprite[] images;
	public GameObject toShuffle = null;

	public int imgidx = 0;
	public bool shuffler = true;

	public bool turn = false;

	public float r = 0f;
	public GameObject mode = null;

	public void Start()
	{
		if(mode.GetComponent<gameMode>().mode == "predictive")
		{
			Shuffle();
			shuffler = false;
		}
	}

	public void Update()
	{
		if(!turn){
		if(mode.GetComponent<gameMode>().mode == "predictive")
		{
			shuffler = false;
		}
		if(mode.GetComponent<gameMode>().mode == "dynamic")
		{
			shuffler = true;
		}
		if(mode.GetComponent<gameMode>().mode == "quantic")
		{
			r = Random.Range(-10f,10.1f);
			if(r < -7.5f || r > 7.5f)
			{
				shuffler = !shuffler;
			} 
		}
		Shuffle();
		}
	}

	public void Shuffle()
	{
		if(shuffler) {
			imgidx = Random.Range (0, images.Length);
		}
	}

	public void Turn()
	{
			toShuffle.GetComponent<Image>().sprite = images[imgidx];
			shuffler = false;
			turn = true;
			GetComponentInParent<DropZone>().Hand[transform.GetSiblingIndex()] = images[imgidx].name;
			mode.GetComponent<gameMode>().getScore();
	}

}

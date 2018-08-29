using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMode : MonoBehaviour {

	public string mode = "predictive";
	public GameObject ResultPanel = null;
	public GameObject PlayerPanel = null;

	public int Score = 0;

	public Text ScoreText = null;
	public Text ModeText = null;

	public Text ScoreExplain = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setMode(string gmode)
	{
		mode = gmode;
		if(mode=="predictive") ModeText.text = "Predictive";
		if(mode=="dynamic") ModeText.text = "Dynamic";
		if(mode=="quantic") ModeText.text = "Quantum";


	}

	public void getScore()
	{
		string[] tplay;
		string[] tres;
		Score = 0;
		ScoreExplain.text = "";

		for(int i=0; i < PlayerPanel.GetComponent<DropZone>().MaxCards; i++)
		{
			tplay = PlayerPanel.GetComponent<DropZone>().Hand[i].Split('_');

			for(int j = 0; j < ResultPanel.GetComponent<DropZone>().MaxCards; j++)
			{
				tres = ResultPanel.GetComponent<DropZone>().Hand[j].Split('_');

				/*Same Card in Column */
				if(tplay[0]==tres[0] && tplay[1]==tres[1] && j == i)
				{
					Score = Score + 52;
					ScoreExplain.text = ScoreExplain.text + ("Same Card in Column! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+"_"+tres[0]+" = + 52\n");
				/*Same Symbol in Column */	
				} else if(tplay[1] == tres[1] && j == i)
				{
					Score = Score + 13;
					ScoreExplain.text = ScoreExplain.text + ("Same Symbol in Column! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 13\n");
				/*Same Card in Row*/	
				} else if(tplay[0] == tres[0] && tplay[1]==tres[1]) {
					Score = Score + 9;
					ScoreExplain.text = ScoreExplain.text + ("Same Card in Row! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 9\n");
				/*Same Suit in Column */
				} else if(tplay[0]==tres[0] && j==i)
				{
					Score = Score + 4;
					ScoreExplain.text = ScoreExplain.text + ("Same Suit in Column! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 4\n");
				/*Same Symbol in Row */
				} else if(tplay[1]==tres[1]) {
					Score = Score + 3;
					ScoreExplain.text = ScoreExplain.text + ("Same Symbol in Row! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 3\n");
				} else if((tplay[0]=="club"||tplay[0]=="spade") && (tres[0]=="club" || tres[0]=="spade") && j==i)
				/*Same Color in Column */
				{
					Score = Score + 2;
					ScoreExplain.text = ScoreExplain.text + ("Same Color In Column! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 2\n");
				} else if((tplay[0]=="diamond"||tplay[0]=="heart") && (tres[0]=="diamond" || tres[0]=="heart") && j==i)
				{
					Score = Score + 2;
					ScoreExplain.text = ScoreExplain.text + ("Same Color In Column! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 2\n");
				/*Same Suit in Row */
				} else if(tplay[0]==tres[0])
				{
					Score = Score + 1;
					ScoreExplain.text = ScoreExplain.text + ("Same Suit in Row! :"+tplay[1]+" of "+tplay[0]+" and "+tres[1]+" of "+tres[0]+"= + 1\n");

				}
			}
		}

		ScoreText.text = Score.ToString();

	}
}

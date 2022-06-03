using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WarePrepButtonScript : MonoBehaviour
{
	public Button yourButton;

	void Start () {
		Button wareButton = yourButton.GetComponent<Button>();
		wareButton.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}

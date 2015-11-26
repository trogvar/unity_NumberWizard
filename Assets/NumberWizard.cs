using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int current;
	int maxGuessesAllowed = 10;
	
	public Text text;
	
	void Init() {
		min = 1;
		max = 1000;
		NextGuess();
	}
	
	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			GuessHigher();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			GuessLower();
		} else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKey(KeyCode.Space)) {
			Application.LoadLevel("Lose");
		}
	}
	
	public void GuessHigher() {
		min = current;
		NextGuess();
	}
	
	public void GuessLower() {
		max = current;
		NextGuess();
	}
	
	void NextGuess() {
		current = Random.Range(min, max+1); //give the human a chance ;)
		maxGuessesAllowed--;
		
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
		
		text.text = current.ToString();
	}
}

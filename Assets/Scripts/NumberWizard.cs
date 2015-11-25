using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int current;
	
	void Init() {
		min = 1;
		max = 1000;
		current = (max + min)/2;
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me.");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
	}
	
	// Use this for initialization
	void Start () {
		Init ();
		Prompt ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			max = current;
			current = (max + min) / 2;
			Prompt();
		} else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			min = current;
			current = (max + min) / 2;
			Prompt();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("================");
			print (" I won! Your number is: " + current);
			print ("================");
		}
	}
	
	void Prompt() {
		print ("Is your number " + current + "?");
		print ("LEFT for lower, RIGHT for greater, ENTER for equals");
	}
}

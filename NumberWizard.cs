using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 8;
	
	public Text text;
	
	
	void StartGame(){
		max = 1001;
		min = 1;
		NextGuess();
		
	}
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
		
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed -1;
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}

using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {

    public enum ColorsChoices {RED, GREEN, BLUE};
    public ColorsChoices playerColor;

    public enum GameStates
    {
        LOADING,
        STARTING,
        PLAYING,
        ENDING
    }

    public GameStates currentGameState = GameStates.LOADING;

	// Use this for initialization
	void Start () {
	
        switch (playerColor)
        {
            case ColorsChoices.GREEN:
                print("This gives access to all weapons");
                break;

            case ColorsChoices.RED:
                print("This gives access to all power-ups");
                break;

            case ColorsChoices.BLUE:
                print("Just Dies");
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
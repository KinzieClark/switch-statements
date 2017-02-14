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

    public string Plants = Flowers; //a little unsure about this one-- still a bit iffy on how to sometimes categorize variables

    public int num= 4;

	void Start () {
	
        switch (playerColor)
        {
            case ColorsChoices.GREEN:
                print("This gives access to all weapons");
                break; //break is absolutely necessary!! without it, the module will freak out and not find an end

            case ColorsChoices.RED:
                print("This gives access to all power-ups");
                break;

            case ColorsChoices.BLUE:
                print("Just Dies");
                break;
        }
        switch (Flowers)
        {
            case Roses:
                print("These are roses");
                break;

            case Tulips:
                print("These are tulips");
                break;
            
            case Hydrangeas:
                print("These are hydrangeas");
                break;

            default:
                print("Unknown flower");
                break;
        }
        switch (num) 
        {
            case 0:
                print("0");
                break;
            case 1:
                print("1");
                break;
            case 2: //the case is what is being compared against the variable
                print("2");
                break;
             case 3:
                print("3");
                break;
            case 4:
                print("4");
                break;
            default: //the "else" of a switch statement
                print("unidentified number");
                break;
        }
}

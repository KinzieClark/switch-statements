using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

    public string[] animals;

    public string animal = "Wolf";

	// Use this for initialization
	void Start () {
        foreach (string animalInAnimals in animals)
        {
            if(animal == animalInAnimals)
            {
                print("I have a match, it is " + animalInAnimals);
            }
            else
            {
                print(animalInAnimals + " is not a match");
            }
        }
	}
}
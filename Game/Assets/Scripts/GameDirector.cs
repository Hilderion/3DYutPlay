using FinalProject;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour {

    // Use this for initialization
	void Start () {
	    Game.Instance.HorseMoved += Game_HorseMoved;

        Game.Instance.FieldPointVisited += Game_FieldPointVisited;

        while (true)
        {
            int dice = Yut.Instance.Roll();

            
        }
	}

    private void Game_FieldPointVisited(object sender, Game.FieldPointVisitedEventArgs e)
    {
        GameObject horse = GameObject.Find("Horse" + e.Horse.Id);
        GameObject point = GameObject.Find("Point" + e.FieldPoint.Id);

        MoveHorse(horse, point);
    }

    private void MoveHorse(GameObject horse, GameObject point)
    {
        // 말을 부드럽게 이동
    }

    private void Game_HorseMoved(object sender, Game.HorseMovedEventArgs e)
    {
    }

    // Update is called once per frame
    void Update () {
		
	}
}

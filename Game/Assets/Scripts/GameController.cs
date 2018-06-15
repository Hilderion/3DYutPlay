using System.Collections;
using System.Collections.Generic;
using FinalProject;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Game.Instance.Started += InstanceOnStarted;
		Game.Instance.HorseSelecting += InstanceOnHorseSelecting;  
		Game.Instance.HorseMoved += InstanceOnHorseMoved;
		
		Game.Instance.Run();
	}

	private void InstanceOnHorseMoved(object sender, Game.HorseMovedEventArgs e)
	{
		Debug.Log(e.Point);
	}

	private void InstanceOnHorseSelecting(object sender, Game.HorseSelectingEventArgs e)
	{
		Debug.Log("select horse");
	}

	private void InstanceOnStarted(object sender, Game.StartedEventArgs e)
	{
		Debug.Log("started");
	}

	public void btnHorseSelection_Click(int horseType)
	{
		Game.Instance.MoveHorse((HorseType) horseType);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

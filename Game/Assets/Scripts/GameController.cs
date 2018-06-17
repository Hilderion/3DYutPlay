using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using FinalProject;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		Game.Instance.Started += InstanceOnStarted;
//		Game.Instance.HorseSelecting += InstanceOnHorseSelecting;  
//		Game.Instance.HorseMoved += InstanceOnHorseMoved;
//		Game.Instance.Run();
		
		NumberGenerator.Instance.NeumberGenrating += InstanceOnNeumberGenrating;
		NumberGenerator.Instance.NeumberGenrated += InstanceOnNeumberGenrated;
		NumberGenerator.Instance.Run();
	}

	private void InstanceOnNeumberGenrating(object sender, NumberGenerator.NeumberGenratingEventArgs e)
	{
		StartCoroutine(NewMethod());
	}

	private IEnumerator NewMethod()
	{
		Debug.Log("Run TestRoutine");
		yield return StartCoroutine(WaitForInstruction());
		_neumberGenratingEventArgs = null;
		Debug.Log("Finish TestRoutine");
	}

	IEnumerator WaitForInstruction()
	{
		yield return new WaitWhile(() => _neumberGenratingEventArgs == null);
	}

	private NumberGenerator.NeumberGenratingEventArgs _neumberGenratingEventArgs;

	private void InstanceOnNeumberGenrated(object sender, NumberGenerator.NeumberGenratedEventArgs e)
	{
		Debug.Log($"{nameof(e.GeneratedNumber)} = {e.GeneratedNumber}");
	}


	public void btnHorseSelection_Click(int interval)
	{
		_neumberGenratingEventArgs = new NumberGenerator.NeumberGenratingEventArgs(interval);
//		Game.Instance.MoveHorse((HorseType) horseType);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

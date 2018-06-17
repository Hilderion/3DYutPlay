using System;
using System.Collections;
using System.Collections.Generic;
using FinalProject;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class GameController : MonoBehaviour {

	private Generator.NumberGeneratingEventArgs _numberGeneratingEventArgs = null;
	private Generator.StringGeneratingEventArgs _stringGeneratingArgs = null; 

	// Use this for initialization
	void Start () {
//		Game.Instance.Started += InstanceOnStarted;
//		Game.Instance.HorseSelecting += InstanceOnHorseSelecting;  
//		Game.Instance.HorseMoved += InstanceOnHorseMoved;
//		Game.Instance.Run();
		
		Generator.Instance.NumberGenerating += InstanceOnNumberGenerating;
		Generator.Instance.NumberGenerated += InstanceOnNumberGenerated;
		Generator.Instance.StringGenerating += InstanceOnStringGenerating;
		Generator.Instance.StringGenerated += InstanceOnStringGenerated;
		Generator.Instance.Run();
	}

	private void InstanceOnStringGenerated(object sender, Generator.StringGeneratedEventArgs e)
	{
		Debug.Log($"[e.Name]");
	}

	private void InstanceOnNumberGenerated(object sender, Generator.NumberGeneratedEventArgs e)
	{
		Debug.Log($"{nameof(e.GeneratedNumber)} = {e.GeneratedNumber}");
	}

	private void InstanceOnStringGenerating(object sender, Generator.StringGeneratingEventArgs e)
	{
		_stringGeneratingArgs = e;
		StartCoroutine("NewMethod", new Func<bool>(() => _stringGeneratingArgs.Name != null));
	}

	private void InstanceOnNumberGenerating(object sender, Generator.NumberGeneratingEventArgs e)
	{
		_numberGeneratingEventArgs = e;
		StartCoroutine("NewMethod", new Func<bool>(() => _numberGeneratingEventArgs.Interval != 0));
//		StartCoroutine(new WaitWhile(() => _numberGeneratingEventArgs.Interval != 0));
	}

	private IEnumerator NewMethod(object value)
	{
		yield return StartCoroutine(WaitForInstruction(value));
	}

	IEnumerator WaitForInstruction(object value)
	{
		yield return new WaitWhile((Func<bool>)value);
	}

	public void btnGenerationNumber_Click()
	{
		_numberGeneratingEventArgs.Interval += 1;

//		Game.Instance.MoveHorse((HorseType) horseType);
	}
	
	public void btnGenerationString_Click()
	{
		_stringGeneratingArgs.Name = DateTime.Now.ToShortDateString();
	}
}

















using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class movHead : MonoBehaviour
{
	public Texture headR;

	public Texture headL;

	public Image head;

	private bool headMove;

	public virtual IEnumerator Start()
	{
		yield return new WaitForSeconds(10f);
		headMove = true;
	}

	public virtual void Update()
	{
		if (headMove)
		{
			headMove = false;
			StartCoroutine(moveHead());
		}
	}

	public virtual IEnumerator moveHead()
	{
		yield return new WaitForSeconds(10f);
		headMove = true;
	}
}

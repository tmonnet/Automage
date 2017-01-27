﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
	public GameObject Reference;
	// Use this for initialization
	void Start ()
	{
		AddMajorTab ();
		AddTab ();
		AddTab ();
		AddTab ();
		AddTab ();
		AddTab ();
		AddTab ();
//		for (int i = 0; i <= 12; i++) {
//		}
	}

	void AddTab ()
	{
		GameObject obj = Instantiate (Reference, transform.position, Quaternion.Euler (0, 0, -87f), transform) as GameObject;
		obj.SetActive (true);
		obj.transform.position += obj.transform.right * transform.childCount * Screen.height * .06f;
		obj.transform.localScale = Vector3.one * .6f;
		obj.GetComponent<Tab> ().order = obj.transform.GetSiblingIndex ();
	}

	void AddMajorTab ()
	{
		GameObject obj = Instantiate (Reference, transform.position, Quaternion.Euler (0, 0, -87f), transform) as GameObject;
		obj.SetActive (true);
		obj.transform.position += obj.transform.right * transform.childCount * Screen.height * .06f;
		obj.transform.localScale = Vector3.one * .6f;
		obj.GetComponent<Tab> ().order = obj.transform.GetSiblingIndex ();


		obj.GetComponent<Tab> ().script.GetComponentInChildren<CodeSerializer> ().everyTick = true;
		Destroy (obj.GetComponent<Tab> ().script.GetComponentInParent<ScriptUI> ().GetComponentsInChildren<InputField> () [1].gameObject);
		obj.GetComponent<Tab> ().script.GetComponentInParent<ScriptUI> ().GetComponentsInChildren<InputField> () [0].text = "Principal";
		obj.GetComponent<Tab> ().script.GetComponentInParent<ScriptUI> ().GetComponentsInChildren<Text> () [1].text = "S'execute en continu";
	}

	// Update is called once per frame
	void Update ()
	{
	}
}

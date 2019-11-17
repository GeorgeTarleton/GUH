using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class JourneyButton : MonoBehaviour {

	GameObject[] mylist;

	// Use this for initialization
	void Start () {
		mylist = Resources.FindObjectsOfTypeAll<GameObject>();
	}

	// Update is called once per frame
	public void OnClick() {
		mylist.Where(obj => obj.name == "MyImpact").SingleOrDefault().SetActive (false);
		mylist.Where(obj => obj.name == "MyJourney").SingleOrDefault().SetActive (true);
		mylist.Where(obj => obj.name == "MyWorld").SingleOrDefault().SetActive (false);
	}
}

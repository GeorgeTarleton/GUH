using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCity : MonoBehaviour {

	public GameObject sky1;
	public GameObject sky2;
	public GameObject sky3;

	public GameObject fac1;
	public GameObject fac2;

	public GameObject tree1;
	public GameObject tree2;
	public GameObject tree3;
	public GameObject tree4;

	public GameObject far1;
	public GameObject far2;
	public GameObject far3;

	public int papercount;
	public int foodcount;
	public int othercount;


	public Sprite[] skysprites;
	public Sprite[] treesprites;
	public Sprite[] facsprites;
	public Sprite[] farmsprites;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//TREES
		float b = Mathf.Floor(papercount / 4);
		tree1.GetComponent<SpriteRenderer>().sprite = treesprites[(int) Mathf.Clamp(b+0, 0f, 3f)];
		tree2.GetComponent<SpriteRenderer>().sprite = treesprites[(int) Mathf.Clamp(b+1, 0f, 3f)];
		tree3.GetComponent<SpriteRenderer>().sprite = treesprites[(int) Mathf.Clamp(b+2, 0f, 3f)];
		tree4.GetComponent<SpriteRenderer>().sprite = treesprites[(int) Mathf.Clamp(b+3, 0f, 3f)];

		//FARMS
		b = Mathf.Floor(foodcount / 4);
		far1.GetComponent<SpriteRenderer>().sprite = farmsprites[(int) Mathf.Clamp(b+0, 0f, 3f)];
		far2.GetComponent<SpriteRenderer>().sprite = farmsprites[(int) Mathf.Clamp(b+1, 0f, 3f)];
		far3.GetComponent<SpriteRenderer>().sprite = farmsprites[(int) Mathf.Clamp(b+2, 0f, 3f)];

		//FACTORIES
		b = Mathf.Floor(othercount / 4);
		fac1.GetComponent<SpriteRenderer>().sprite = facsprites[3 - (int) Mathf.Clamp(b+0, 0f, 3f)];
		fac2.GetComponent<SpriteRenderer>().sprite = facsprites[3 - (int) Mathf.Clamp(b+1, 0f, 3f)];

		//BIG BUILDINGS
		b = Mathf.Floor((foodcount+papercount+othercount) / 4);
		sky3.GetComponent<SpriteRenderer>().sprite = skysprites[(int) Mathf.Clamp(b+0, 0f, 3f)];
		sky2.GetComponent<SpriteRenderer>().sprite = skysprites[(int) Mathf.Clamp(b+1, 0f, 3f)];
		sky1.GetComponent<SpriteRenderer>().sprite = skysprites[(int) Mathf.Clamp(b+2, 0f, 3f)];
	}
}

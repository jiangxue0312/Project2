using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoleManager : MonoBehaviour {

    // Use this for initialization
    // List of the Mole 
    public List<GameObject> moleList = new List<GameObject>();
    // Time to wait before start the game, start to go time
    public float StartDelay;
    // Time before showing the mole 
    public float ShowDelay;
    // Time before hiding the mole
    public float HideDelay;

    // Maximum number of moles show in one term
    //public int MaxMole;

	void Start () {
        InvokeRepeating("MoleShow", StartDelay, ShowDelay);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void MoleShow()
    {
        moleList[Random.Range(0, moleList.Count)].GetComponentInChildren<Mole>().Show();
    }
}

using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour {

    private Animator animator;
    private bool showflag = false;
    
    
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (showflag)
        {
            GameObject moles = GameObject.Find("Moles");
            MoleManager t = moles.GetComponent<MoleManager>();
            float timeHide = t.HideDelay;
            StartCoroutine(Hide(timeHide));
        }
	
	}


    public void Show()
    {
        if (showflag) return;
        animator.Play("show");
        showflag = true;
    }

    IEnumerator Hide(float timeHide)
    {
        showflag = false;
        yield return new WaitForSeconds(timeHide);
        animator.Play("hide");
    }
}

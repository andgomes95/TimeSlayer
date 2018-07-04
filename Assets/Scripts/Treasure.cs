using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treasure : MonoBehaviour {

	private bool click = false;
	public Animator anime;

	void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
			anime.SetBool ("click", !click);
			StartCoroutine (waitTime ());
        }
    }
	IEnumerator waitTime(){
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
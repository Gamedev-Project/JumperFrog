using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Score.CurrentScore += 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}

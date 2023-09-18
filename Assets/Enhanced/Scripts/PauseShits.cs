using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseShits : MonoBehaviour 
{
	[SerializeField]
	private GameObject _pauseMenu;

	public GameObject pauseMenu
	{
		get
		{
			return _pauseMenu;
		}
	}

    public void Resume()
    {
		pauseMenu.SetActive(false);
	}

    public void Respawn()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

    public void EXIT()
    {
		SceneManager.LoadScene("EhancedTitle");
	}  
}
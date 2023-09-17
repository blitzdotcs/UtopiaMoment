using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnhancedMenu : MonoBehaviour 
{
    public void MainPlay()
    {
		SceneManager.LoadScene("Sandbox");
	}

    public void MS()
    {
		SceneManager.LoadScene("ModeSelector");
	}

	public void EHCredits()
	{
		SceneManager.LoadScene("Creds");
	}

	public void CredsBack()
	{
		SceneManager.LoadScene("EhancedTitle");
	}    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelectorMenu : MonoBehaviour 
{
    public void Mode1()
    {
		SceneManager.LoadScene("Mode1");
	}

    public void Mode2()
    {
		SceneManager.LoadScene("Mode2");
	}

	public void Mode3()
	{
		SceneManager.LoadScene("Mode3");
	}

	public void Back()
	{
		SceneManager.LoadScene("EhancedTitle");
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelectorMenu : MonoBehaviour 
{
    public void SA2GHZ()
    {
		SceneManager.LoadScene("sa2ghz");
	}

    public void RRDX()
    {
		SceneManager.LoadScene("gayroaddx");
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
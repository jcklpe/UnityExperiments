using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
public void PlayButton (int scene)
	{
		Application.LoadLevel (scene);
	}

public void ExitButton () {

	Application.Quit ();
}
}

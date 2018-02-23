using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

    public void PlayPlot()
    {
        Application.LoadLevel("PlotScene");
    }

    public void PlayGame()
    {
        Application.LoadLevel("GameScene");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }

}

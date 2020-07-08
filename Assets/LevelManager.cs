using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CargaEscena(string nombreEscena) {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir() {
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }
}

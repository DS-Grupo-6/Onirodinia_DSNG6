using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_menu : MonoBehaviour
{
    public void IniciarFase1(){ 
        Debug.Log("entrou");
        UnityEngine.SceneManagement.SceneManager.LoadScene("CutScene1");
    }

    public void FecharJogo()
    {
        Application.Quit();
    } 
}

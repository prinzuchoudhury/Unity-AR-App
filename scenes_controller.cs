using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public void explosion()
    {
        SceneManager.LoadScene("make_blocks");
    }

    public void firewok()
    {
        SceneManager.LoadScene("Firework");
    }
    public void blade()
    {
        SceneManager.LoadScene("Turbine");
    }
    public void helicopter()
    {
        SceneManager.LoadScene("Animator");
    }
    public void team_members()
    {
        SceneManager.LoadScene("Team_Members");
    }
    public void exit_application()
    {
        Debug.Log("You Quit the application");
        Application.Quit();
    }

    public void Exit_To_menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

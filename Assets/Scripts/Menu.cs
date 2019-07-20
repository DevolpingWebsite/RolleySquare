using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void loadlevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void loadlevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void loadlevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void loadlevel5()
    {
        SceneManager.LoadScene(5);
    }

    public void loadlevel6()
    {
        SceneManager.LoadScene(6);
    }

    public void loadlevel7()
    {
        SceneManager.LoadScene(7);
    }

    public void loadlevel8()
    {
        SceneManager.LoadScene(8);
    }

    public void loadlevel9()
    {
        SceneManager.LoadScene(9);
    }

    public void loadlevel10()
    {
        SceneManager.LoadScene(10);
    }
}

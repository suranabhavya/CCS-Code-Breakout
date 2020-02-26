using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void loadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void loadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void loadLevel1Scene()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exited");
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene(21);
    }
    public void loadQuestion1Scene()
    {
        SceneManager.LoadScene(22, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion1Scene()
    {
        SceneManager.UnloadScene(22);
    }
    public void loadQuestion2Scene()
    {
        SceneManager.LoadScene(23, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion2Scene()
    {
        SceneManager.UnloadScene(23);
    }
    public void loadQuestion3Scene()
    {
        SceneManager.LoadScene(24, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion3Scene()
    {
        SceneManager.UnloadScene(24);
    }
    public void loadQuestion4Scene()
    {
        SceneManager.LoadScene(25, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion4Scene()
    {
        SceneManager.UnloadScene(25);
    }
    public void loadQuestion5Scene()
    {
        SceneManager.LoadScene(26, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion5Scene()
    {
        SceneManager.UnloadScene(26);
    }
    public void loadQuestion6Scene()
    {
        SceneManager.LoadScene(27, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion6Scene()
    {
        SceneManager.UnloadScene(27);
    }
    public void loadQuestion7Scene()
    {
        SceneManager.LoadScene(28, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion7Scene()
    {
        SceneManager.UnloadScene(28);
    }
    public void loadQuestion8Scene()
    {
        SceneManager.LoadScene(29, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion8Scene()
    {
        SceneManager.UnloadScene(29);
    }
    public void loadQuestion9Scene()
    {
        SceneManager.LoadScene(30, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion9Scene()
    {
        SceneManager.UnloadScene(30);
    }
    public void loadQuestion10Scene()
    {
        SceneManager.LoadScene(31, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion10Scene()
    {
        SceneManager.UnloadScene(31);
    }
    public void loadQuestion11Scene()
    {
        SceneManager.LoadScene(32, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion11Scene()
    {
        SceneManager.UnloadScene(32);
    }
    public void loadQuestion12Scene()
    {
        SceneManager.LoadScene(33, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion12Scene()
    {
        SceneManager.UnloadScene(33);
    }
    public void loadQuestion13Scene()
    {
        SceneManager.LoadScene(34, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion13Scene()
    {
        SceneManager.UnloadScene(34);
    }
    public void loadQuestion14Scene()
    {
        SceneManager.LoadScene(35, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion14Scene()
    {
        SceneManager.UnloadScene(35);
    }
    public void loadQuestion15Scene()
    {
        SceneManager.LoadScene(36, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion15Scene()
    {
        SceneManager.UnloadScene(36);
    }
    public void loadQuestion16Scene()
    {
        SceneManager.LoadScene(37, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion16Scene()
    {
        SceneManager.UnloadScene(37);
    }
    public void loadQuestion17Scene()
    {
        SceneManager.LoadScene(38, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion17Scene()
    {
        SceneManager.UnloadScene(38);
    }
    public void loadQuestion18Scene()
    {
        SceneManager.LoadScene(39, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion18Scene()
    {
        SceneManager.UnloadScene(39);
    }
    public void loadQuestion19Scene()
    {
        SceneManager.LoadScene(40, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion19Scene()
    {
        SceneManager.UnloadScene(40);
    }
    public void loadQuestion20Scene()
    {
        SceneManager.LoadScene(41, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion20Scene()
    {
        SceneManager.UnloadScene(41);
    }
    public void loadQuestion21Scene()
    {
        SceneManager.LoadScene(42, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion21Scene()
    {
        SceneManager.UnloadScene(42);
    }
    public void loadQuestion22Scene()
    {
        SceneManager.LoadScene(43, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion22Scene()
    {
        SceneManager.UnloadScene(43);
    }
    public void loadQuestion23Scene()
    {
        SceneManager.LoadScene(44, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion23Scene()
    {
        SceneManager.UnloadScene(44);
    }
    public void loadQuestion24Scene()
    {
        SceneManager.LoadScene(45, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion24Scene()
    {
        SceneManager.UnloadScene(45);
    }
    public void loadQuestion25Scene()
    {
        SceneManager.LoadScene(46, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion25Scene()
    {
        SceneManager.UnloadScene(46);
    }
    public void loadQuestion26Scene()
    {
        SceneManager.LoadScene(47, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion26Scene()
    {
        SceneManager.UnloadScene(47);
    }
    public void loadQuestion27Scene()
    {
        SceneManager.LoadScene(48, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion27Scene()
    {
        SceneManager.UnloadScene(48);
    }
    public void loadQuestion28Scene()
    {
        SceneManager.LoadScene(49, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion28Scene()
    {
        SceneManager.UnloadScene(49);
    }
    public void loadQuestion29Scene()
    {
        SceneManager.LoadScene(50, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion29Scene()
    {
        SceneManager.UnloadScene(50);
    }
    public void loadQuestion30Scene()
    {
        SceneManager.LoadScene(51, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion30Scene()
    {
        SceneManager.UnloadScene(51);
    }
    public void loadQuestion31Scene()
    {
        SceneManager.LoadScene(52, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion31Scene()
    {
        SceneManager.UnloadScene(52);
    }
    public void loadQuestion32Scene()
    {
        SceneManager.LoadScene(53, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion32Scene()
    {
        SceneManager.UnloadScene(53);
    }
    public void loadQuestion33Scene()
    {
        SceneManager.LoadScene(54, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion33Scene()
    {
        SceneManager.UnloadScene(54);
    }
    public void loadQuestion34Scene()
    {
        SceneManager.LoadScene(55, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion34Scene()
    {
        SceneManager.UnloadScene(55);
    }
    public void loadQuestion35Scene()
    {
        SceneManager.LoadScene(56, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion35Scene()
    {
        SceneManager.UnloadScene(56);
    }
    public void loadQuestion36Scene()
    {
        SceneManager.LoadScene(57, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion36Scene()
    {
        SceneManager.UnloadScene(57);
    }
    public void loadQuestion37Scene()
    {
        SceneManager.LoadScene(58, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion37Scene()
    {
        SceneManager.UnloadScene(58);
    }
    public void loadQuestion38Scene()
    {
        SceneManager.LoadScene(59, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion38Scene()
    {
        SceneManager.UnloadScene(59);
    }
    public void loadQuestion39Scene()
    {
        SceneManager.LoadScene(60, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion39Scene()
    {
        SceneManager.UnloadScene(60);
    }
    public void loadQuestion40Scene()
    {
        SceneManager.LoadScene(61, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion40Scene()
    {
        SceneManager.UnloadScene(61);
    }
    public void loadQuestion41Scene()
    {
        SceneManager.LoadScene(62, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion41Scene()
    {
        SceneManager.UnloadScene(62);
    }
    public void loadQuestion42Scene()
    {
        SceneManager.LoadScene(63, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion42Scene()
    {
        SceneManager.UnloadScene(63);
    }
    public void loadQuestion43Scene()
    {
        SceneManager.LoadScene(64, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion43Scene()
    {
        SceneManager.UnloadScene(64);
    }
    public void loadQuestion44Scene()
    {
        SceneManager.LoadScene(65, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion44Scene()
    {
        SceneManager.UnloadScene(65);
    }
    public void loadQuestion45Scene()
    {
        SceneManager.LoadScene(66, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion45Scene()
    {
        SceneManager.UnloadScene(66);
    }
    public void loadQuestion46Scene()
    {
        SceneManager.LoadScene(67, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion46Scene()
    {
        SceneManager.UnloadScene(67);
    }
    public void loadQuestion47Scene()
    {
        SceneManager.LoadScene(68, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion47Scene()
    {
        SceneManager.UnloadScene(68);
    }
    public void loadQuestion48Scene()
    {
        SceneManager.LoadScene(69, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion48Scene()
    {
        SceneManager.UnloadScene(69);
    }
    public void loadQuestion49Scene()
    {
        SceneManager.LoadScene(70, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion49Scene()
    {
        SceneManager.UnloadScene(70);
    }
    public void loadQuestion50Scene()
    {
        SceneManager.LoadScene(71, LoadSceneMode.Additive);
    }
    public void continueAfterQuestion50Scene()
    {
        SceneManager.UnloadScene(71);
    }
}


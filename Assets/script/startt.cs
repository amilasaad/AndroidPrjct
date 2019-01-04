using UnityEngine;
using UnityEngine.SceneManagement;

public class startt : MonoBehaviour
{
    public void DTSRT ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("You Click me  . . .");
    }
}

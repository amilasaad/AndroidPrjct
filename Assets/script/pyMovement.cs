using UnityEngine;
using UnityEngine.SceneManagement;
public class pyMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float ffrc = 2000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ffrc * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 280, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

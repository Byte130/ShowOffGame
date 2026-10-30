using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerTakesHits : MonoBehaviour
{
    float Lives = 3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;

        }
        if (Lives <= 0)
        {
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("DeathPit"))
        {
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.CompareTag("StartBossFight"))
        {
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("CannonBall"))
        { 
            Destroy(collision.gameObject);
            Cursor.visible = true;
            Lives -= 1;

        }
    }
}

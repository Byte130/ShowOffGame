using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerTakesHits : MonoBehaviour
{
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
            SceneManager.LoadScene(2);
            
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; 
public class LobbyController : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }
    
}

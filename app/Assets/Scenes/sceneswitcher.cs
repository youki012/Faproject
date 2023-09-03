
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitcher : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void scenechanger(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

}

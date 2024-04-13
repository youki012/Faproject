
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public int time = 15;
    public bool unlocked =false;
    string timedscene;
    public void scenechanger(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    
    public void scenechangertimed(string scenename)
    {
        unlocked = true;
        timedscene = scenename;
    }
    public void Update()
    {
        
        if (unlocked)
        {
            time++;
            if(time > 50)
            {

                time = 0;
                unlocked = false;
                SceneManager.LoadScene(timedscene);
            }
        }
    }
}

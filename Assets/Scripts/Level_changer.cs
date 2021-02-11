using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_changer : MonoBehaviour
{
    public Animator Anim;
    private int Level_to_load;

    public void Fade_to_level(int Level_index)
    {
        Level_to_load = Level_index;
        Anim.SetTrigger("Fade_out");
    }

    public void On_fade_complete()
    {
        SceneManager.LoadScene(Level_to_load);
    }

    public void On_fade_out_complete()
    {
        this.gameObject.SetActive(false);
    }
}

using UnityEngine;

public class DEBUG_script : MonoBehaviour
{
    public void TEST_SCRIPT()
    {
        PlayerPrefs.DeleteAll();
        print("test_script!");
    }
}

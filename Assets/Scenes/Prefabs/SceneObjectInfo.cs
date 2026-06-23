using UnityEngine;

public class SceneObjectInfo : MonoBehaviour
{
    [SerializeField] private string creatorName = "username";

    void Awake()
    {
        PrintInfoMessage();
    }

    private void PrintInfoMessage()
    {
        Debug.Log("Object added to scene by: " + creatorName);
    }
}

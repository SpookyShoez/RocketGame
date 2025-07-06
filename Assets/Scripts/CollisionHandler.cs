using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Everything looking good.");
                break;
            case "Finish":
                Debug.Log("You made it to the finish line!");
                break;
            case "Fuel":
                Debug.Log("You collected some fuel!");
                break;
            default:
                Debug.Log("You crashed!");
                break;
        }
    }
}

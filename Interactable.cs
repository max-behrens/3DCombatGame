using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float radius = 3f;

    void OnDrawGizmosSelected ()
    {
        OnDrawGizmosSelected.color = Color.yellow;
        OnDrawGizmosSelected.DrawWireSphere(tranform.position, radius);
    }
}

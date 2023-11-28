using UnityEngine;

public class BombBehaviourDestructionShere : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float destructionSphereRadius = 3;

    void Start()
    {
        // after 3 seconds instantiate the explosion
        float delay = 3;
        Invoke(nameof(Explode), delay);

    }

    private void Explode()
    {        
        // create explosion at same location as this player
        GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        
        // destroy particle system after 1 second
        Destroy(explosion, 1);
        
        // --- do any collision logic for bomb here -----
        Vector3 center = transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(center, destructionSphereRadius);
        // loop for all colliders within "blast radius"
        foreach (var collider in hitColliders)
        {
            // if collider in a GameObject tagged Destroyable, then destroy it !
            if (collider.CompareTag("Destroyable"))
            {
                print("destroying GameObject name = " + collider.name);
                Destroy(collider.gameObject);
            }
        }
        
        // destroy this bomb GameObject
        Destroy(gameObject);
    }
}

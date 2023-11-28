using UnityEngine;

public static class Rigidbody2DExtension{
    public static void AddExplosionForce(this Rigidbody2D body, float explosionForce, Vector3 explosionPosition, float explosionRadius){
        Vector3 forceVector = (body.transform.position - explosionPosition);
        float wearoff = 1 - (forceVector.magnitude / explosionRadius);
        body.AddForce(forceVector.normalized * explosionForce * wearoff);
    }
}
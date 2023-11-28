using UnityEngine;

public class TileManager : MonoBehaviour {
    public int rows = 50;
    public int cols = 50;
    public GameObject prefabClickableTile;

    void Start () {
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                float y = 0.01f;
                Vector3 pos = new Vector3(r - rows/2, y, c - cols/2);
                Instantiate(prefabClickableTile, pos, Quaternion.identity);
            }
        }
    }
}


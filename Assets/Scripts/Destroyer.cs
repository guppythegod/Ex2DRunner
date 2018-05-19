using UnityEngine;

public class Destroyer : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // End Scene In Here
            Debug.Break();
            return;
        }

        if (other.transform.root.gameObject)
        {
            Destroy(other.transform.root.gameObject);
        }
    }

}

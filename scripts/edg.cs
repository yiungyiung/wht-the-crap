using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edg : MonoBehaviour
{
    // Start is called before the first frame update

  
        private void Awake() {
        PolygonCollider2D poly = GetComponent<PolygonCollider2D>();
        if(poly == null){
            poly = gameObject.AddComponent<PolygonCollider2D>();
        }
        Vector2[] points = poly.points;
        EdgeCollider2D edge = gameObject.AddComponent<EdgeCollider2D>();
        edge.points = points;
        edge.edgeRadius=0.2f;
        Destroy(poly);
    }

}

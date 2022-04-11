using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollect : MonoBehaviour
{
    Movement moveMent;
    [SerializeField] GameObject gainerPS;
    [SerializeField] GameObject burnerPS;
    // Start is called before the first frame update
    void Start()
    {
        moveMent = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gainer")
        {
            moveMent.Grow();
            Instantiate(gainerPS, transform);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Burner")
        {
            moveMent.Burn();
            Instantiate(burnerPS, transform);
            Destroy(collision.gameObject);
        }

    }
    
}

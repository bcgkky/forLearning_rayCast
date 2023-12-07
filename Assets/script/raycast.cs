using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public GameObject mermi;
    public GameObject mermiCikis;
    public GameObject mermiIzı;


    void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(mermiCikis.transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                Instantiate(mermiIzı, hit.point, Quaternion.identity);
                hit.transform.gameObject.GetComponent<dusman>().DarbeAl(20);
            }
                

            /*if(Physics.Raycast(mermiCikis.transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                hit.rigidbody.AddForce(Vector3.forward * 800);
            }*/

            //Instantiate(mermi, mermiCikis.transform.position, Quaternion.identity);
        }

    }
    void FixedUpdate()
    {



        float dik = Input.GetAxis("Horizontal");
        float yan = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(dik, 0f, yan) * 20 * Time.deltaTime);
        





        /*int layerMask = 1 << 8;
        layerMask = ~layerMask;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            hit.transform.name = "gag";
            hit.transform.GetComponent<MeshRenderer>().enabled = false;
            //Destroy(hit.transform.gameObject);
            Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("hedef var");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("hedef yok");
        }*/
        
    }
}

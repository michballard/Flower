using UnityEngine;
using System.Collections;
using BLINDED_AM_ME;

public class ExampleUseof_MeshCut : MonoBehaviour {

	public Material capMaterial;

	void Update(){

		if(Input.GetMouseButtonDown(0)){
            //Create an empty raycast hit to assign later on
			RaycastHit hit;

            //If you hit an object in front of you (transform.forward) //Only returns 1 object.
			if(Physics.Raycast(transform.position, transform.forward, out hit)){
                //Create a victim object for any hit.
				GameObject victim = hit.collider.gameObject;
                //Create pieces that it will get cut into 
				GameObject[] pieces = MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

                //pieces[0] = left side
                //pieces[1] = right side

                //If Rigidbody does not exist on pieces[1] then Add a RIGIDBODY
                if (!pieces[1].GetComponent<Rigidbody>())
					pieces[1].AddComponent<Rigidbody>();

				Destroy(pieces[1], 1);
			}

		}
	}


	void OnDrawGizmosSelected() {

		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, transform.position + transform.forward * 5.0f);
		Gizmos.DrawLine(transform.position + transform.up * 0.5f, transform.position + transform.up * 0.5f + transform.forward * 5.0f);
		Gizmos.DrawLine(transform.position + -transform.up * 0.5f, transform.position + -transform.up * 0.5f + transform.forward * 5.0f);

		Gizmos.DrawLine(transform.position, transform.position + transform.up * 0.5f);
		Gizmos.DrawLine(transform.position,  transform.position + -transform.up * 0.5f);

	}

}

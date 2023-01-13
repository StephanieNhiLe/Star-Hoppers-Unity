using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{
    void Update () {

		Rigidbody2D rb = GetComponent<Rigidbody>();
		// MeshRenderer mr = GetComponent<MeshRenderer>();
		Material mat = rb.material;
		// Material mat = mr.material;

		Vector2 offset = mat.mainTextureOffset;

		offset.x += Time.deltaTime / 10f;

		mat.mainTextureOffset = offset;

	}
}

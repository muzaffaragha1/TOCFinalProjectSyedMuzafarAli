using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

/// <summary>
/// Manages the flower color
/// </summary>

public class Flower : MonoBehaviour
{

    [Tooltip("The color when the flower is full")]
    public Color fullFlowerColor = new Color(1f, 0f, 0.3f);

    [Tooltip("The color when the flower is empty")]
    public Color emptyFlowerColor = new Color(0.5f, 0f, 1f);

    /// <summary>
    /// The trigger collider representing the necter
    /// </summary>
    [HideInInspector]
    public Collider nectarCollider;

    //The Solid collider representing the flower collider
    public Collider flowerCollider;

    // The flower's material
    private Material flowerMaterial;

    ///<summary>
    /// A vector pointing straight out of flower
    /// </summary>
    public Vector3 FlowerUpVector
    {
        get
        {
            return nectarCollider.transform.up;
        }
    }

    /// <summary>
    /// The center position of the necter collider
    /// </summary>
    public Vector3 FlowerCenterPosition
    {
        get
        {
            return nectarCollider.transform.position;
        }
    }

    ///<summary>
    /// The amount of necter remaining in the flower
    ///</summary>
    
    public float NectarAmount { get; private set; }

    ///<summary>
    /// Whether the flower has any necter
    /// </summary>
    public bool HasNectar
    {
        get
        {
            return NectarAmount > 0f;
        }
    }
    /// <summary>
    /// Attempts to remove nectar from the flower
    /// </summary>
    /// <param name="amount">The amount of nectar to remove</param>
    /// <returns>The actual amount succesfully removed</returns>
    public float Feed(float amount)
    {
        //Track how much nectar was succesfully taken (can not take more than available)
        float nectarTaken = Mathf.Clamp(amount, 0f, NectarAmount);

        // subtract the nectar amount taken
        NectarAmount -= amount;

        if (NectarAmount <= 0)
        {
            //No nectar remaining
            NectarAmount = 0;

            // Disable the flower and nectar colliders
            flowerCollider.gameObject.SetActive(false);
            nectarCollider.gameObject.SetActive(false);

            //change the color of flower to indicate that it is empty
            flowerMaterial.SetColor("_BaseColor", emptyFlowerColor);
        }
        return nectarTaken;
    }
    /// <summary>
    /// Resets the flower
    /// </summary>
    public void ResetFlower()
    {
        //Refill the flower
        NectarAmount = 1f;

        //Enable the flower and nectar colliders

        nectarCollider.gameObject.SetActive(true);
        flowerCollider.gameObject.SetActive(true);

        // Change the flower color to indicate that it is full
        flowerMaterial.SetColor("_BaseColor", fullFlowerColor);

    }

    /// <summary>
    /// Called when the flower wakes up
    /// </summary>
    public void Awake()
    {
        // Find the flower's mesh renderer and get the main material
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        flowerMaterial = meshRenderer.material;

        //Find flower and nectar collider
        flowerCollider = transform.Find("FlowerCollider").GetComponent<Collider>();
        nectarCollider = transform.Find("FlowerNectarCollider").GetComponent<Collider>();

    }
}

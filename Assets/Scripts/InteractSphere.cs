using System;
using UnityEngine;

public class InteractSphere : MonoBehaviour, IInteractable
{


    [SerializeField] private Material greenMaterial;
    [SerializeField] private Material redMaterial;
    [SerializeField] private MeshRenderer meshRenderer;

    private bool isGreen;

    private void Start()
    {
        SetColorGreen();
    }

    private void SetColorGreen()
    {
        isGreen = true;
        meshRenderer.material = greenMaterial;
    }

    private void SetColorRed()
    {
        isGreen = false;
        meshRenderer.material = redMaterial;
    }

    public void Interact(Action onInteractionComplete)
    {
        throw new NotImplementedException();
    }
}

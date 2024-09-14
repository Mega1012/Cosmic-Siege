using UnityEngine;

public abstract class AbstractTransform : MonoBehaviour
{
    public float GSX { get => transform.position.x; set => transform.position = new Vector3(value,GSY,GSZ); }
    public float GSY { get => transform.position.x; set => transform.position = new Vector3(GSX,value,GSZ); }
    public float GSZ { get => transform.position.x; set => transform.position = new Vector3(GSX,GSY,value); }
}

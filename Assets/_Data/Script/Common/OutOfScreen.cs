using UnityEngine;


public class OutOfScreen : IOutOfScreen
{
    public bool IsCompleteOutOfLeftScreen(Renderer renderer, Camera camera)
    {
        Bounds bounds = renderer.bounds;
        Vector3 max = camera.WorldToViewportPoint(bounds.max);

        return max.x < 0;

    }

    public bool IsCompleteOutOfScreen(Renderer renderer, Camera camera)
    {
        Bounds bounds = renderer.bounds;
        Vector3 min = camera.WorldToViewportPoint(bounds.min);
        Vector3 max = camera.WorldToViewportPoint(bounds.max);
        if (min.x > 1 || max.x < 0 || min.y > 1 || max.y < 0)
        {
            return true;
        }
        return false;
    }
}

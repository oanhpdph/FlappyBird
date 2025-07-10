using UnityEngine;

public interface IOutOfScreen
{
    bool IsCompleteOutOfScreen(Renderer renderer, Camera camera);
    bool IsCompleteOutOfLeftScreen(Renderer renderer, Camera camera);

}

using UnityEngine;

public class GorozontalOrient : MonoBehaviour
{      
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}

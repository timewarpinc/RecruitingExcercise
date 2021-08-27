using UnityEngine;

namespace Dungeon.Scripts
{
    /// <summary>
    ///     Example of a simple game manager that uses the DungeonGeneratorRunner to generate levels.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public GameObject Canvas;

        public void Awake()
        {
            if (Canvas != null) Canvas.SetActive(true);
        }
    }
}
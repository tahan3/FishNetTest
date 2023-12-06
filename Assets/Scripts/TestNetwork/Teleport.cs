using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TestNetwork
{
    public class Teleport : MonoBehaviour
    {
        private const string SCENE_TELEPORT = "Multiplayer";
        
        private void OnTriggerEnter(Collider other)
        {
            SceneManager.LoadScene(SCENE_TELEPORT);
        }
    }
}
using System;
using UnityEngine;
using Zenject;

namespace Configs
{
    [CreateAssetMenu(fileName = "PlayerConfiguration", menuName = "ScriptableObjects/PlayerConfigurationObject", order = 1)]
    public class PlayerConfig : ScriptableObject
    {
        public GameObject playerPrefab;
        public float moveSpeed;
    }
}
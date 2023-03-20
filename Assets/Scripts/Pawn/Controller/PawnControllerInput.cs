﻿using UnityEngine;
using UnityEngine.InputSystem;

public class PawnControllerInput : MonoBehaviour, IPawnControllerInput
{
    [field: SerializeField] public float Move { get; set; }
    [field: SerializeField] public bool JumpPressed { get; set; }
    [field: SerializeField] public bool JumpPerformed { get; set; }
    [field: SerializeField] public bool JumpReleased { get; set; }
    [field: SerializeField] public bool Interact { get; set; }
}
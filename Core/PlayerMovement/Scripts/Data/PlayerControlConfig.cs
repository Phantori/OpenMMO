using UnityEngine;

namespace OpenMMO
{
    /// <summary>Input Axis are set from Edit>PlayerSettings>Input</summary>
    public enum InputAxis
    {
        /// <summary>Horizontal Input axis. Corresponds to Left/Right Arrows or A and D Keys.</summary>
        [Tooltip("Horizontal Input axis. Corresponds to Left/Right Arrows or A and D Keys.")]
        Horizontal,
        /// <summary>Vertical Input axis. Corresponds to Up/Down Arrows or W and S Keys.</summary>
        [Tooltip("Vertical Input axis. Corresponds to Up/Down Arrows or W and S Keys.")]
        Vertical,
        /// <summary>Right Trigger axis. Corresponds to Left Ctrl and Left Mouse Button.</summary>
        [Tooltip("Right Trigger axis. Corresponds to Left Ctrl and Left Mouse Button.")]
        Fire1,
        /// <summary>Left Trigger axis. Corresponds to Left Alt and Right Mouse Button.</summary>
        [Tooltip("Left Trigger axis. Corresponds to Left Alt and Right Mouse Button.")]
        Fire2,
        /// <summary>Corresponds to Left Shift and Middle Mouse Button.</summary>
        [Tooltip("Corresponds to Left Shift and Middle Mouse Button.")]
        Fire3,
        /// <summary>Action Button. Corresponds to Enter Key and Gamepad Button 0.</summary>
        [Tooltip("Action Button. Corresponds to Enter Key and Gamepad Button 0.")]
        Submit,
        /// <summary>Cancel Button. Corresponds to Escape Key and Gamepad Button 1.</summary>
        [Tooltip("Cancel Button. Corresponds to Escape Key and Gamepad Button 1.")]
        Cancel
    }

    [CreateAssetMenu(menuName = "OpenMMO/Config/Player Controls")]
    public class PlayerControlConfig : ScriptableObject
    {

        [Header("Input")]
        public KeyCode runKey = KeyCode.LeftShift;
        public InputAxis moveAxisHorizontal = InputAxis.Horizontal;
        public InputAxis moveAxisVertical = InputAxis.Vertical;

        [Header("Move Speed")]
        [Range(0, 10)] public float turnSpeedMultiplier = 0.5f;
        [Range(0, 10)] public float moveSpeedMultiplier = 1.0f;

        [Header("Move Speed Scale")]
        [Tooltip("")]
        [Range(0, 10)] public float walkSpeedScale = 1.0f;
        [Tooltip("")]
        [Range(0, 10)] public float runSpeedScale = 1.5f;
        [Tooltip("")]
        [Range(0, 10)] public float backpedalSpeedScale = 0.5f;
    }
}
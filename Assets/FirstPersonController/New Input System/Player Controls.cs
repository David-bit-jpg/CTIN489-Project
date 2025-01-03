//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/FirstPersonController/New Input System/Player Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c7cd91e9-41e9-4353-be82-3e29a81d2e74"",
            ""actions"": [
                {
                    ""name"": ""RunHold"",
                    ""type"": ""Button"",
                    ""id"": ""b0d5380f-0bc4-4e39-8cf2-308d753add01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1,pressPoint=1.401298E-45)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RunToggle"",
                    ""type"": ""Button"",
                    ""id"": ""9e01d24a-1799-4d7e-b023-05b2b76794a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lean Left"",
                    ""type"": ""Button"",
                    ""id"": ""f3b11602-dcac-4728-b3e4-f5303e57d69d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lean Right"",
                    ""type"": ""Button"",
                    ""id"": ""d40a844f-dc88-459c-8977-21af215a5dc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lean Up"",
                    ""type"": ""Button"",
                    ""id"": ""443b0b08-086d-45bf-9881-94627d786570"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Unlock Camera"",
                    ""type"": ""Button"",
                    ""id"": ""974ddfa1-8d0e-4191-9f77-c8b76a72c8c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""427ffd78-d02c-4b4b-90a2-63ff1f24bdb5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""f37ac09d-a8ab-4d4d-8d0a-52732f8a6e05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""f5638f1e-44b5-4d2e-b48d-c4e35f7d40d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapDelay=0.3)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b02f2bb-b9c7-4d34-a182-34d1581dacba"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""462bf9f7-6516-4b22-9d1c-7e1827478172"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab9f7590-02bc-4018-b42a-fb05f331f125"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bee0dcd3-9c86-4371-ba56-5304ed205231"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91aa92f8-0f22-4330-8aa5-718121f5278a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2aa288b4-cf7b-490d-95ff-d660a6cd1888"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc5d6092-8445-475d-9394-583c30cc598e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ece80449-9aa7-4373-837b-86d4ceb06677"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f98c53e7-d49b-4352-a82b-66b22941a910"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c51ba33e-9b85-4d1c-a99d-271818f3b0f8"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lean Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6402de0c-d98e-4410-95b2-096618baead6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""77ba1339-0401-421f-aab3-4ac853f5d2fe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6a44b7f8-1e35-4b1f-aea6-714e6de856ea"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c3030d85-a0b2-4265-890f-56d369e8ced9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1d3dea8d-538b-4b7f-ba8b-2a3c0b76b57d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""16008727-b775-4c2a-860f-e7118a666622"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""56b4ed6b-7a2f-460e-aa2e-501f1472fb69"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b07799aa-ab83-4693-9444-69af407466de"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""64856148-d4f4-49d5-89e4-d16c30b4fdc9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f3fb56b0-23c7-4c31-9b9d-400514d4ebb9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""364fc7e6-67d1-44fe-b751-09576cea88bd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.1,y=0.1)"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7863fe29-280b-446d-b853-d33e6d1fec81"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=3,y=3)"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""282c7e2b-d248-46a8-b4d9-eb8b63206eec"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""424322b8-046b-4cb0-8140-73808ea0390e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ab1d2e8-8fb9-4c12-b7ed-3234628281b9"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unlock Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88869330-a08d-4cc4-a231-745f5a883d4c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Unlock Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_RunHold = m_Player.FindAction("RunHold", throwIfNotFound: true);
        m_Player_RunToggle = m_Player.FindAction("RunToggle", throwIfNotFound: true);
        m_Player_LeanLeft = m_Player.FindAction("Lean Left", throwIfNotFound: true);
        m_Player_LeanRight = m_Player.FindAction("Lean Right", throwIfNotFound: true);
        m_Player_LeanUp = m_Player.FindAction("Lean Up", throwIfNotFound: true);
        m_Player_UnlockCamera = m_Player.FindAction("Unlock Camera", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Camera = m_Player.FindAction("Camera", throwIfNotFound: true);
        m_Player_Dodge = m_Player.FindAction("Dodge", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_RunHold;
    private readonly InputAction m_Player_RunToggle;
    private readonly InputAction m_Player_LeanLeft;
    private readonly InputAction m_Player_LeanRight;
    private readonly InputAction m_Player_LeanUp;
    private readonly InputAction m_Player_UnlockCamera;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Camera;
    private readonly InputAction m_Player_Dodge;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RunHold => m_Wrapper.m_Player_RunHold;
        public InputAction @RunToggle => m_Wrapper.m_Player_RunToggle;
        public InputAction @LeanLeft => m_Wrapper.m_Player_LeanLeft;
        public InputAction @LeanRight => m_Wrapper.m_Player_LeanRight;
        public InputAction @LeanUp => m_Wrapper.m_Player_LeanUp;
        public InputAction @UnlockCamera => m_Wrapper.m_Player_UnlockCamera;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Camera => m_Wrapper.m_Player_Camera;
        public InputAction @Dodge => m_Wrapper.m_Player_Dodge;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @RunHold.started += instance.OnRunHold;
            @RunHold.performed += instance.OnRunHold;
            @RunHold.canceled += instance.OnRunHold;
            @RunToggle.started += instance.OnRunToggle;
            @RunToggle.performed += instance.OnRunToggle;
            @RunToggle.canceled += instance.OnRunToggle;
            @LeanLeft.started += instance.OnLeanLeft;
            @LeanLeft.performed += instance.OnLeanLeft;
            @LeanLeft.canceled += instance.OnLeanLeft;
            @LeanRight.started += instance.OnLeanRight;
            @LeanRight.performed += instance.OnLeanRight;
            @LeanRight.canceled += instance.OnLeanRight;
            @LeanUp.started += instance.OnLeanUp;
            @LeanUp.performed += instance.OnLeanUp;
            @LeanUp.canceled += instance.OnLeanUp;
            @UnlockCamera.started += instance.OnUnlockCamera;
            @UnlockCamera.performed += instance.OnUnlockCamera;
            @UnlockCamera.canceled += instance.OnUnlockCamera;
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Dodge.started += instance.OnDodge;
            @Dodge.performed += instance.OnDodge;
            @Dodge.canceled += instance.OnDodge;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @RunHold.started -= instance.OnRunHold;
            @RunHold.performed -= instance.OnRunHold;
            @RunHold.canceled -= instance.OnRunHold;
            @RunToggle.started -= instance.OnRunToggle;
            @RunToggle.performed -= instance.OnRunToggle;
            @RunToggle.canceled -= instance.OnRunToggle;
            @LeanLeft.started -= instance.OnLeanLeft;
            @LeanLeft.performed -= instance.OnLeanLeft;
            @LeanLeft.canceled -= instance.OnLeanLeft;
            @LeanRight.started -= instance.OnLeanRight;
            @LeanRight.performed -= instance.OnLeanRight;
            @LeanRight.canceled -= instance.OnLeanRight;
            @LeanUp.started -= instance.OnLeanUp;
            @LeanUp.performed -= instance.OnLeanUp;
            @LeanUp.canceled -= instance.OnLeanUp;
            @UnlockCamera.started -= instance.OnUnlockCamera;
            @UnlockCamera.performed -= instance.OnUnlockCamera;
            @UnlockCamera.canceled -= instance.OnUnlockCamera;
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Dodge.started -= instance.OnDodge;
            @Dodge.performed -= instance.OnDodge;
            @Dodge.canceled -= instance.OnDodge;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnRunHold(InputAction.CallbackContext context);
        void OnRunToggle(InputAction.CallbackContext context);
        void OnLeanLeft(InputAction.CallbackContext context);
        void OnLeanRight(InputAction.CallbackContext context);
        void OnLeanUp(InputAction.CallbackContext context);
        void OnUnlockCamera(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
    }
}

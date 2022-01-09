// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""d92a292c-95c7-4418-a55d-103a6aeac1bd"",
            ""actions"": [
                {
                    ""name"": ""KeystoneChange"",
                    ""type"": ""Value"",
                    ""id"": ""9f9b967b-03cf-49e4-9896-fea42b6439f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""5a02e413-2a11-4e35-b92b-749e00de0834"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Stick"",
                    ""id"": ""a2b2e985-23a1-404d-805f-b81aa4845941"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeystoneChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4bb4d745-c60c-4157-85cd-46e8eb853356"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeystoneChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5d2f23e2-5ffd-45da-8e94-7b6f41178432"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeystoneChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ccd898a5-1588-4f34-b288-496e48f0e40e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeystoneChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a20ae73f-8fd7-4e57-a03e-fc2d14d3054c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeystoneChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""id"": ""b089d567-4f9a-4758-bb7f-9352ac4b4140"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""58349c40-b3bb-4636-9557-0669af99dc3e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7c053fe9-52f2-4948-807c-cd15333be70a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardControls"",
            ""bindingGroup"": ""KeyboardControls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_KeystoneChange = m_Movement.FindAction("KeystoneChange", throwIfNotFound: true);
        m_Movement_Zoom = m_Movement.FindAction("Zoom", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_KeystoneChange;
    private readonly InputAction m_Movement_Zoom;
    public struct MovementActions
    {
        private @InputActions m_Wrapper;
        public MovementActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @KeystoneChange => m_Wrapper.m_Movement_KeystoneChange;
        public InputAction @Zoom => m_Wrapper.m_Movement_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @KeystoneChange.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnKeystoneChange;
                @KeystoneChange.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnKeystoneChange;
                @KeystoneChange.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnKeystoneChange;
                @Zoom.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KeystoneChange.started += instance.OnKeystoneChange;
                @KeystoneChange.performed += instance.OnKeystoneChange;
                @KeystoneChange.canceled += instance.OnKeystoneChange;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    private int m_KeyboardControlsSchemeIndex = -1;
    public InputControlScheme KeyboardControlsScheme
    {
        get
        {
            if (m_KeyboardControlsSchemeIndex == -1) m_KeyboardControlsSchemeIndex = asset.FindControlSchemeIndex("KeyboardControls");
            return asset.controlSchemes[m_KeyboardControlsSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnKeystoneChange(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
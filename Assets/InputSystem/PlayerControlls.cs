// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""KeyboardMouse"",
            ""id"": ""6129f08a-b015-4fcd-a0c3-711ed1b727b1"",
            ""actions"": [
                {
                    ""name"": ""FlipWorlds"",
                    ""type"": ""Button"",
                    ""id"": ""da5f5a50-60cb-40ab-a6d5-0cdfcdab3ed7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""59d8d321-c7d0-483b-b1e3-8f7900487834"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6c07da76-b951-4488-b090-03db6b4c19e8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipWorlds"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""998520f6-1fe2-42f5-a8a4-ef661f33f513"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1208933e-5ab4-44db-a28a-cb5ac4d323d9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5cbe0e33-b441-4826-8c9f-7d23b2fb3a41"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a7aef3f5-db36-4a23-82aa-08c2c11f2def"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3d1f47e6-ad80-4081-b28f-a697527de81a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardMouse
        m_KeyboardMouse = asset.FindActionMap("KeyboardMouse", throwIfNotFound: true);
        m_KeyboardMouse_FlipWorlds = m_KeyboardMouse.FindAction("FlipWorlds", throwIfNotFound: true);
        m_KeyboardMouse_WASD = m_KeyboardMouse.FindAction("WASD", throwIfNotFound: true);
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

    // KeyboardMouse
    private readonly InputActionMap m_KeyboardMouse;
    private IKeyboardMouseActions m_KeyboardMouseActionsCallbackInterface;
    private readonly InputAction m_KeyboardMouse_FlipWorlds;
    private readonly InputAction m_KeyboardMouse_WASD;
    public struct KeyboardMouseActions
    {
        private @PlayerControlls m_Wrapper;
        public KeyboardMouseActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlipWorlds => m_Wrapper.m_KeyboardMouse_FlipWorlds;
        public InputAction @WASD => m_Wrapper.m_KeyboardMouse_WASD;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterface != null)
            {
                @FlipWorlds.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFlipWorlds;
                @FlipWorlds.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFlipWorlds;
                @FlipWorlds.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFlipWorlds;
                @WASD.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnWASD;
            }
            m_Wrapper.m_KeyboardMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FlipWorlds.started += instance.OnFlipWorlds;
                @FlipWorlds.performed += instance.OnFlipWorlds;
                @FlipWorlds.canceled += instance.OnFlipWorlds;
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
            }
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);
    public interface IKeyboardMouseActions
    {
        void OnFlipWorlds(InputAction.CallbackContext context);
        void OnWASD(InputAction.CallbackContext context);
    }
}

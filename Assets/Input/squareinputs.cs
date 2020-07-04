// GENERATED AUTOMATICALLY FROM 'Assets/Input/squareinputs.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Squareinputs : IInputActionCollection
{
    private InputActionAsset asset;
    public Squareinputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""squareinputs"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""37f3a3f4-8d06-4d9e-969f-7536dcbeff79"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""aa59fcf9-ab31-4af3-a219-32e06c9b16fc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""87db6063-50ae-43ae-ba5e-b2b55b48226a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shrink"",
                    ""type"": ""Button"",
                    ""id"": ""377eed01-5ab1-42fb-a964-73225255ef4a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6fd6202b-e6a6-47be-8029-71238e1048fc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7cf2ae1d-06bb-422e-b3ad-e6d6fb17c71f"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick   Joystick>/Stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a07c262-8779-4526-9615-c85628b9992d"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick   Joystick>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2032cf2-8ce1-43e1-96a4-8057e3adfacb"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick   Joystick>/button1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e557c65-59b2-4a6c-bacb-615805f93fc1"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick   Joystick>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        m_Gameplay_Grow = m_Gameplay.GetAction("Grow");
        m_Gameplay_Shrink = m_Gameplay.GetAction("Shrink");
        m_Gameplay_Jump = m_Gameplay.GetAction("Jump");
    }

    ~Squareinputs()
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Grow;
    private readonly InputAction m_Gameplay_Shrink;
    private readonly InputAction m_Gameplay_Jump;
    public struct GameplayActions
    {
        private Squareinputs m_Wrapper;
        public GameplayActions(Squareinputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Grow => m_Wrapper.m_Gameplay_Grow;
        public InputAction @Shrink => m_Wrapper.m_Gameplay_Shrink;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Grow.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                Grow.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                Grow.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGrow;
                Shrink.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShrink;
                Shrink.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShrink;
                Shrink.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShrink;
                Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Grow.started += instance.OnGrow;
                Grow.performed += instance.OnGrow;
                Grow.canceled += instance.OnGrow;
                Shrink.started += instance.OnShrink;
                Shrink.performed += instance.OnShrink;
                Shrink.canceled += instance.OnShrink;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnGrow(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}

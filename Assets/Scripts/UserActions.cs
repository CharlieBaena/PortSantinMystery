// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/UserActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UserActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""22921f0f-5872-438d-9505-314c769f0098"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""4562e418-5ccd-4335-be26-e6840879bde3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interactue"",
                    ""type"": ""Button"",
                    ""id"": ""7a379087-7a6f-4b34-b2a6-731ca7ce814a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""93b8a503-a0b1-4a6d-b0e9-ce2af1a13f8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""02a8b31c-3684-4d91-a0b2-160f03ddf1f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""2c6680f2-2cdb-400a-9e83-c3059ab3f4b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d4ec8c78-d488-49c8-925c-7efb7361b459"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d06dc0b8-9897-4335-a35e-df04bf68f85c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""481edd74-6815-403b-924b-454f8f4e02fb"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c1eb008-3b2a-4b15-a439-b716bae98f4f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3943c0c6-9ae3-4c7b-830a-03336791d08b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""<-->"",
                    ""id"": ""5a39f483-09cb-4dcc-af2f-86f4731f6a13"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""141c2fb8-d610-4e8d-aacc-12600801a752"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b16be27a-d2d2-4501-b8b1-3b698031e3d9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f1113fd9-d23e-48b0-bd0d-a5d9b1d490eb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Interactue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e90618e5-f3f5-4001-a63d-bc5ed6152712"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interactue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d7a12f2-6c43-4ded-b402-31045519f26f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6072e93-607a-4c1d-bff7-e9810803d1a1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c04938aa-89f2-4f03-83ac-919323659944"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0f3d67c-70ec-49c5-9188-0edd2813a7a2"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""6c962096-761c-4801-aa7f-d6948b5e5bba"",
            ""actions"": [
                {
                    ""name"": ""NextLine"",
                    ""type"": ""Button"",
                    ""id"": ""67199a24-d82d-43bc-bc3c-9704b7a91d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e069bcb4-7a5b-4535-bb15-ee8f76822026"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5a6f7c0-d576-4e31-bd81-4da5e6aeb6ef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Pause"",
            ""id"": ""283f74c9-afb8-4043-949b-3396169f1f4e"",
            ""actions"": [
                {
                    ""name"": ""Open/Close"",
                    ""type"": ""Button"",
                    ""id"": ""33939f93-c26e-410e-94da-460a585493b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f3c30d4e-9b14-4ff0-9492-ce6dc89cbd84"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Open/Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b592153c-886d-4f7e-bcca-8624de08c332"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Open/Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard and Mouse"",
            ""bindingGroup"": ""KeyBoard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interactue = m_Player.FindAction("Interactue", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_NextLine = m_UI.FindAction("NextLine", throwIfNotFound: true);
        // Menu Pause
        m_MenuPause = asset.FindActionMap("Menu Pause", throwIfNotFound: true);
        m_MenuPause_OpenClose = m_MenuPause.FindAction("Open/Close", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interactue;
    private readonly InputAction m_Player_Inventory;
    private readonly InputAction m_Player_Sprint;
    public struct PlayerActions
    {
        private @UserActions m_Wrapper;
        public PlayerActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interactue => m_Wrapper.m_Player_Interactue;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Interactue.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractue;
                @Interactue.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractue;
                @Interactue.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractue;
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interactue.started += instance.OnInteractue;
                @Interactue.performed += instance.OnInteractue;
                @Interactue.canceled += instance.OnInteractue;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_NextLine;
    public struct UIActions
    {
        private @UserActions m_Wrapper;
        public UIActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextLine => m_Wrapper.m_UI_NextLine;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @NextLine.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNextLine;
                @NextLine.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNextLine;
                @NextLine.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNextLine;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextLine.started += instance.OnNextLine;
                @NextLine.performed += instance.OnNextLine;
                @NextLine.canceled += instance.OnNextLine;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Menu Pause
    private readonly InputActionMap m_MenuPause;
    private IMenuPauseActions m_MenuPauseActionsCallbackInterface;
    private readonly InputAction m_MenuPause_OpenClose;
    public struct MenuPauseActions
    {
        private @UserActions m_Wrapper;
        public MenuPauseActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenClose => m_Wrapper.m_MenuPause_OpenClose;
        public InputActionMap Get() { return m_Wrapper.m_MenuPause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuPauseActions set) { return set.Get(); }
        public void SetCallbacks(IMenuPauseActions instance)
        {
            if (m_Wrapper.m_MenuPauseActionsCallbackInterface != null)
            {
                @OpenClose.started -= m_Wrapper.m_MenuPauseActionsCallbackInterface.OnOpenClose;
                @OpenClose.performed -= m_Wrapper.m_MenuPauseActionsCallbackInterface.OnOpenClose;
                @OpenClose.canceled -= m_Wrapper.m_MenuPauseActionsCallbackInterface.OnOpenClose;
            }
            m_Wrapper.m_MenuPauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenClose.started += instance.OnOpenClose;
                @OpenClose.performed += instance.OnOpenClose;
                @OpenClose.canceled += instance.OnOpenClose;
            }
        }
    }
    public MenuPauseActions @MenuPause => new MenuPauseActions(this);
    private int m_KeyBoardandMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardandMouseScheme
    {
        get
        {
            if (m_KeyBoardandMouseSchemeIndex == -1) m_KeyBoardandMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard and Mouse");
            return asset.controlSchemes[m_KeyBoardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteractue(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNextLine(InputAction.CallbackContext context);
    }
    public interface IMenuPauseActions
    {
        void OnOpenClose(InputAction.CallbackContext context);
    }
}

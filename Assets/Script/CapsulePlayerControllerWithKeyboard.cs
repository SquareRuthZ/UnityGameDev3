using UnityEngine;
using UnityEngine.InputSystem;

namespace GameDev3Library.PlayerSystem
{
    public abstract class CapsulePlayerControllerWithKeyboard: MonoBehaviour,ICapsulePlayerController
    {
            [SerializeField] protected float m_RotationSpeed = 180;
            [SerializeField] protected float m_DirectionalSpeed = 3;
            [SerializeField] protected float m_DirectionalSprintSpeed = 5;
        
            [Header("Keys Config")]
            [SerializeField] protected Key m_ForwardKey = Key.W;
            [SerializeField] protected Key m_BackwardKey = Key.S;
            [SerializeField] protected Key m_TurnLeftKey = Key.A;
            [SerializeField] protected Key m_TurnRightKey = Key.D;

            [SerializeField] protected Key m_SprintKey = Key.LeftShift;

            protected virtual void Update()
            {
                Keyboard keyboard = Keyboard.current;

                if (keyboard[m_TurnLeftKey].isPressed){
                    TurnLeft();
                }else if (keyboard[m_TurnRightKey].isPressed){
                    TurnRight();
                }

                if (keyboard[m_ForwardKey].isPressed){
                    if (keyboard[m_SprintKey].isPressed)
                    {
                        MoveForwardSprint();
                    }
                    else
                    {
                        MoveForward();
                    }
                }else if (keyboard[m_BackwardKey].isPressed){
                    MoveBackward();
                }            
            }

            public abstract void MoveForward();
            public abstract void MoveForwardSprint();
            public abstract void MoveBackward();
            public abstract void TurnLeft();
            public abstract void TurnRight();
        
    }
}
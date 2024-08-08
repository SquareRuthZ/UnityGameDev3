namespace GameDev3Library.PlayerSystem
{
    public interface ICapsulePlayerController
    {
        void MoveForward();
        void MoveForwardSprint();
        
        void MoveBackward();
        
        void TurnLeft();
        void TurnRight();
    }
}
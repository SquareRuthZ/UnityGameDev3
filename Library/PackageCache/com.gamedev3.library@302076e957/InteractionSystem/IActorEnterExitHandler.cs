using UnityEngine;

namespace GameDev3Library.InteractionSystem
{
    public interface IActorEnterExitHandler
    {
        void ActorEnter(GameObject actor);
        void ActorExit(GameObject actor);
    }
}
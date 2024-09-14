using UnityEngine;

public class HashAnimationKeys
{
    private struct HashAnimationsKeys
    {
        public const string idle = "idle";
        public const string die = "die";
        public const string destroy = "destroy";
        public const string trigger = "trigger";
    }
    public static readonly int idle = Animator.StringToHash(HashAnimationsKeys.idle);
    public static readonly int die = Animator.StringToHash(HashAnimationsKeys.die);
    public static readonly int destroy = Animator.StringToHash(HashAnimationsKeys.destroy);
    public static readonly int trigger = Animator.StringToHash(HashAnimationsKeys.trigger);
}

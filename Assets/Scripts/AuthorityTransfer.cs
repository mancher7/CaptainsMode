using Coherence;
using Coherence.Toolkit;
using UnityEngine;

public class AuthorityTransfer : MonoBehaviour
{
    private CoherenceSync sync;

    private void Awake()
    {
        sync = GetComponent<CoherenceSync>();
    }

    // Вызывается, например, по нажатию кнопки
    public void TransferAuthorityToPlayer()
    {
        if (sync != null)
        {
            sync.RequestAuthority(Coherence.AuthorityType.Full);
        }
    }
}

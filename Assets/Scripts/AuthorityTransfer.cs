using Coherence;
using Coherence.Toolkit;
using UnityEngine;

public class AuthorityTransfer : MonoBehaviour
{
    private CoherenceSync sync;

    private void Start()
    {
        sync = FindAnyObjectByType<CoherenceSync>();

        sync.OnStateAuthority.AddListener(OnAuthorityGained);
        sync.OnStateRemote.AddListener(OnAuthorityLost);
    }

    private void OnAuthorityGained()
    {
        Debug.Log("AftorityON");
    }

    private void OnAuthorityLost()
    {
        Debug.Log("AftorityOFF");
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

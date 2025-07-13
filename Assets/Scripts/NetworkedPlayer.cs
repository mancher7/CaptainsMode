//using Coherence;
//using Coherence.Toolkit;
//using UnityEngine;

//public class NetworkedPlayer : MonoBehaviour
//{
//    [SerializeField] private CoherenceSync sync;

//    private void Awake()
//    {
//        sync.OnStateAuthority.AddListener(OnAuthorityGained);
//        sync.OnStateRemote.AddListener(OnAuthorityLost);
//    }

//    private void OnAuthorityGained()
//    {
//        Debug.Log("OnAftority");
//    }

//    private void OnAuthorityLost()
//    {
//        Debug.Log("OffAftority");
//    }

    ////  public void TransferAuthorityToPlayer(ulong targetClientId)
    ////{
    ////    if (sync != null)
    ////    {
    ////        sync.RequestAuthority(Coherence.AuthorityType.Full, targetClientId);
    ////    }
    ////}
//}

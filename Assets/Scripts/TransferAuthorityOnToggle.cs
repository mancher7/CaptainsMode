//using UnityEngine;
//using UnityEngine.UI;
//using Coherence.Toolkit;

//public class TransferAuthorityOnToggle : MonoBehaviour
//{
//    public CoherenceSync coherenceSync; // Ссылка на CoherenceSync объекта
//    private Toggle toggle;

//    private void Awake()
//    {
//        toggle = GetComponent<Toggle>();
//        if (toggle == null)
//        {
//            Debug.LogError("Toggle component not found!");
//            return;
//        }

//        toggle.onValueChanged.AddListener(OnToggleChanged);
//    }

//    private void OnToggleChanged(bool isOn)
//    {
//        if (isOn)
//        {
//            // Передаём авторитет локальному игроку (владельцу)
//            if (coherenceSync != null)
//            {
//                coherenceSync.RequestAuthority();
//            }
//            else
//            {
//                Debug.LogError("CoherenceSync not assigned!");
//            }
//        }
//        else
//        {
//            // Если нужно отозвать авторитет (опционально)
//             coherenceSync.RemoveAuthority();
//        }
//    }
//}

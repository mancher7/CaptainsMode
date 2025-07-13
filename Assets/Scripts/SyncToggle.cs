//using UnityEngine;
//using UnityEngine.UI;
//using Coherence.Toolkit;

//public class SyncToggle : MonoBehaviour
//{
//    public Toggle toggle;
//    private CoherenceSync coherenceSync;

//    private void Awake()
//    {
//        coherenceSync = GetComponent<CoherenceSync>();
//        toggle.onValueChanged.AddListener(OnToggleChanged);
//    }

//    private void OnToggleChanged(bool newValue)
//    {
//        // Обновляем синхронизированную переменную
//        coherenceSync.SendCommand<SyncToggle>(nameof(UpdateToggleState),
//            Coherence.MessageTarget.Other, newValue);
//    }

//    // Этот метод вызывается удалённо через Coherence
//    public void UpdateToggleState(bool newValue)
//    {
//        toggle.isOn = newValue; // Обновляем визуальное состояние
//    }
//}

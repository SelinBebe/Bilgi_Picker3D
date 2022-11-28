using UnityEngine;

namespace Signals
{
    public class CoreUISignals : MonoSingleton<CoreUISignals>
    {
       public UnityAction<UIPanelTypes, int> onOpenPanel = delegrate {};
       public UnityAction<int> onClosePanel = delegrate {};
       public UnityAction onCloseAllPanels = delegrate {};
            
    }
}
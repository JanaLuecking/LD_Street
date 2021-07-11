using UnityEngine;
using UnityEngine.UI;

namespace Gamekit3D.GameCommands
{

    public class GameplayCounter : GameCommandHandler
    {
        public int currentCount = 0;
        public int targetCount = 3;
	public Text t1;
	public GameObject anzeige;

        [Space]
        [Tooltip("Send a command when increment is performed. (optional)")]
        public SendGameCommand onIncrementSendCommand;
        [Tooltip("Perform an action when increment is performed. (optional)")]
        public GameCommandHandler onIncrementPerformAction;
        [Space]
        [Tooltip("Send a command when target count is reacted. (optional)")]
        public SendGameCommand onTargetReachedSendCommand;
        [Tooltip("Perform an action when target count is reacted. (optional)")]
        public GameCommandHandler onTargetReachedPerformAction;

	void Start()
   	 {anzeige.SetActive(false);}

        public override void PerformInteraction()
        {
            currentCount += 1;
		if (currentCount == 1)
{anzeige.SetActive(true);}
		t1.text = currentCount.ToString();
            if (currentCount >= targetCount)
            {
                if (onTargetReachedPerformAction != null) onTargetReachedPerformAction.PerformInteraction();
                if (onTargetReachedSendCommand != null) onTargetReachedSendCommand.Send();
                isTriggered = true;
            }
            else
            {
                if (onIncrementPerformAction != null) onIncrementPerformAction.PerformInteraction();
                if (onIncrementSendCommand != null) onIncrementSendCommand.Send();
                isTriggered = false;
            }
        }

    }

}

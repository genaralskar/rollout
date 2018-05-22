using RoboRyanTron.Unite2017.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace genaralskar
{
	public class RaiseEventOnDrag : MonoBehaviour, IDragHandler
	{
	
		public GameEvent[] Events;
		
		public void OnDrag(PointerEventData eventData)
		{
			foreach (var e in Events)
			{
				e.Raise();
			}
		}
	}
}


using RoboRyanTron.Unite2017.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace genaralskar
{
	public class RaiseEventOnPointerUp : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
	{
	
		public GameEvent[] Events;
		

		public void OnPointerUp(PointerEventData eventData)
		{
			foreach (var e in Events)
			{
				e.Raise();
			}
		}

		public void OnPointerDown(PointerEventData eventData) //needed for OnPointerUp to work
		{
			
		}
	}
}


using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		

		public int MovementRange = 100;
		
		public string horizontalAxisName = "Horizontal"; // The name given to the horizontal axis for the cross platform input
		public string verticalAxisName = "Vertical"; // The name given to the vertical axis for the cross platform input
		/*public InputBase horizontalInput;
		public InputBase verticalInput;*/
		

		Vector3 m_StartPos;
		CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis; // Reference to the joystick in the cross platform input
		CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis; // Reference to the joystick in the cross platform input

		void OnEnable()
		{
			CreateVirtualAxes();
		}

        void Start()
        {
            m_StartPos = transform.position;
        }

		void UpdateVirtualAxes(Vector3 value)
		{
			var delta = m_StartPos - value;
			delta.y = -delta.y;
			delta /= MovementRange;
			
			m_HorizontalVirtualAxis.Update(-delta.x);
		

		
			m_VerticalVirtualAxis.Update(delta.y);
			
		}

		void CreateVirtualAxes()
		{
			// set axes to use

			// create new axes based on axes to use
			
			m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
			CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
		
		
			m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
			CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			
		}


		public void OnDrag(PointerEventData data)
		{
			Vector3 newPos = Vector3.zero;

			
			int deltaX = (int)(data.position.x - m_StartPos.x);
		//	delta = Mathf.Clamp(delta, - MovementRange, MovementRange);
			newPos.x = deltaX;
		

		
			int deltaY = (int)(data.position.y - m_StartPos.y);
		//	delta = Mathf.Clamp(delta, -MovementRange, MovementRange);
			newPos.y = deltaY;
			
			transform.position = Vector3.ClampMagnitude(new Vector3( newPos.x, newPos.y, newPos.z), MovementRange) + m_StartPos;
			UpdateVirtualAxes(transform.position);
		}


		public void OnPointerUp(PointerEventData data)
		{
			transform.position = m_StartPos;
			UpdateVirtualAxes(m_StartPos);
		}


		public void OnPointerDown(PointerEventData data) { }

		void OnDisable()
		{
			// remove the joysticks from the cross platform input
			
			m_HorizontalVirtualAxis.Remove();
		
		
			m_VerticalVirtualAxis.Remove();
			
		}
	}
}
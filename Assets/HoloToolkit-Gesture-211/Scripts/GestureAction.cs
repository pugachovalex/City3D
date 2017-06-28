using Academy.HoloToolkit.Unity;
using UnityEngine;

/// <summary>
/// GestureAction performs custom actions based on 
/// which gesture is being performed.
/// </summary>
/// 
namespace HoloToolkit.Unity.InputModule
{


public class GestureAction : MonoBehaviour,                             
                             IManipulationHandler
                             
   
{
    [Tooltip("Rotation max speed controls amount of rotation.")]
    public float RotationSensitivity = 10.0f;

    private Vector3 manipulationPreviousPosition;

    private float rotationFactor;

    private IInputSource currentInputSource = null;
    private uint currentInputSourceId;
    private Vector3 handPosition;
        private bool isRotating = false;


        void Update()
        {
            if (isRotating) { 

                currentInputSource.TryGetPosition(currentInputSourceId, out handPosition);
                rotationFactor = handPosition.x * RotationSensitivity;
                transform.Rotate(new Vector3(0, -1 * rotationFactor, 0));
            }
        }

    private void PerformRotation()
    {
       // if (GestureManager.Instance.IsNavigating &&
       //     (!ExpandModel.Instance.IsModelExpanded ||
        //    (ExpandModel.Instance.IsModelExpanded && HandsManager.Instance.FocusedGameObject == gameObject)))
      //  {
           /* TODO: DEVELOPER CODING EXERCISE 2.c */

            // 2.c: Calculate rotationFactor based on GestureManager's NavigationPosition.X and multiply by RotationSensitivity.
            // This will help control the amount of rotation.
            

            // 2.c: transform.Rotate along the Y axis using rotationFactor.
            transform.Rotate(new Vector3(0, -1 * rotationFactor, 0));
        //}
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {

            
            currentInputSource.TryGetPosition(currentInputSourceId, out handPosition);
            manipulationPreviousPosition = handPosition;
            isRotating = true;
        }

        public void OnManipulationUpdated(ManipulationEventData eventData)
    {


            /* TODO: DEVELOPER CODING EXERCISE 4.a */
            Vector3 newHandPosition;
            currentInputSource.TryGetPosition(eventData.SourceId, out newHandPosition);
            Vector3 moveVector = Vector3.zero;
            // 4.a: Calculate the moveVector as position - manipulationPreviousPosition.
            moveVector = newHandPosition - manipulationPreviousPosition;
            // 4.a: Update the manipulationPreviousPosition with the current position.
            manipulationPreviousPosition = newHandPosition;

            // 4.a: Increment this transform's position by the moveVector.
            transform.position += moveVector;

        
    }

        public void OnManipulationCompleted(ManipulationEventData eventData)
        {
            isRotating = false;
        }
        public void OnManipulationCanceled(ManipulationEventData eventData)
        {

        }

    }
}
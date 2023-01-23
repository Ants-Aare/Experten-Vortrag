using AAA.Editor.Runtime.Attributes;
using UnityEngine;
using NaughtyAttributes;

namespace AAA.XYRalityTest
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [ShowNonSerializedField, ReadOnly] private Vector3 _inputMoveDirection = Vector3.zero;
        [SerializeField, Self] private Rigidbody rBody;


        void FixedUpdate()
        {
            ReceiveInputs();
            ApplyMovement();
        }

        private void ReceiveInputs()
        {
            _inputMoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        }

        private void ApplyMovement()
        {
            rBody.velocity = _inputMoveDirection * movementSpeed;
        }
    }
}
using UnityEngine;
using System.Collections;

namespace HeneGames.SimpleAirplaneController
{
    public class AirplaneController : MonoBehaviour
    {
        [Header("Flight speed")]
        [SerializeField] private float defaultSpeed = 10f;
        [SerializeField] private float maxSpeed = 20f;
        
        private float currentSpeed;
        
        private void Start()
        {
            currentSpeed = defaultSpeed;
        }
        
        private void Update()
        {
            // Simple flight control
            transform.position += transform.forward * currentSpeed * Time.deltaTime;
            
            // Increase/decrease speed with keyboard
            if(Input.GetKey(KeyCode.W))
            {
                currentSpeed = Mathf.Lerp(currentSpeed, maxSpeed, Time.deltaTime);
            }
            else
            {
                currentSpeed = Mathf.Lerp(currentSpeed, defaultSpeed, Time.deltaTime);
            }
        }
    }
} 
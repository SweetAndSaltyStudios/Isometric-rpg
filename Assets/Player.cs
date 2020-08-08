using UnityEngine;

namespace SweetAndSaltyStudios
{
	public class Player : MonoBehaviour
	{
        #region VARIABLES

        private Rigidbody2D rb2D;

        #endregion VARIABLES

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

       

        #endregion CUSTOM_FUNCTIONS
    }
}
//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Player.cs (16/07/2018)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Controller del jugador/Cliente.								\\
// Fecha Mod:		16/07/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Controller del jugador/Cliente.</para>
	/// </summary>
	public class Player : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Prefab del cubo para instanciar.</para>
		/// </summary>
		public GameObject prefabCubo;                                                   // Prefab del cubo para instanciar
		#endregion

		#region Inicializadores
		/// <summary>
		/// <para>Inicializador de <see cref="Player"/>.</para>
		/// </summary>
		private void Start()// Inicializador de Player
		{
			Instantiate(prefabCubo);
		}
		#endregion
	}
}
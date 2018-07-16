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
using UnityEngine.Networking;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Controller del jugador/Cliente.</para>
	/// </summary>
	public class Player : NetworkBehaviour 
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
			// Comprobamos si es el objeto local
			if (!isLocalPlayer)
			{
				// Este objeto es de otro jugador
				return;
			}

			// Solo instanciara el cubo si es Local. Es decir, si soy el cliente.
			// Decir al servidor que instancie nuestra unidad
			CmdSpawnUnidad();
		}
		#endregion

		#region Servidor
		/// <summary>
		/// <para>Le dice al servidor que instancie la unidad.</para>
		/// </summary>
		[Command]
		private void CmdSpawnUnidad()
		{
			// Instanciamos localmente el objeto
			GameObject go = Instantiate(prefabCubo);

			// Propagamos el objeto creado a los demas clientes.
			NetworkServer.Spawn(go);
		}
		#endregion
	}
}
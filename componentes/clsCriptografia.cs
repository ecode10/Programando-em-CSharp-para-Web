using System;
using System.Security.Cryptography;

namespace PrimeiroSistema.componentes
{
	/// <summary>
	/// Summary description for clsCriptografia.
	/// </summary>
	public class clsCriptografia
	{
		//variaveis para criptografia
		private static string chave = "dotnet63"; //chave de criptografia

		Byte[] IV = new byte[] {0x0012, 0x0034,0x0056, 0x0078, 0x0090, 0x00AB, 0x00CD, 0x00EF}; 
		Byte[] key = System.Text.Encoding.UTF8.GetBytes(chave); 


		/// <summary>
		/// metodo que encriptografa os dados de acordo com a minha variavel
		/// acima e os valores passos
		/// ex.: encrypt("valor")
		/// </summary>
		/// <param name="strValor"></param>
		/// <returns>string</returns>
		public string encrypt(string strValor) 
		{ 
			try 
			{ 
				DESCryptoServiceProvider des = new DESCryptoServiceProvider(); 
				Byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(strValor); 
				System.IO.MemoryStream ms = new System.IO.MemoryStream(); 
				CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write); 
				cs.Write(inputByteArray, 0, inputByteArray.Length); 
				cs.FlushFinalBlock(); 
				return Convert.ToBase64String(ms.ToArray()); 
			} 
			catch (System.Exception ex) 
			{ 
				return ex.Message;
			} 
		} 

		/// <summary>
		/// metodo que descriptografa os dados de acordo com os valores passos
		/// e as variaveis acima
		/// ex.: decrypt("valor_criptografado")
		/// </summary>
		/// <param name="strValor"></param>
		/// <returns>string</returns>
		public string decrypt(string strValor) 
		{ 
			Byte[] inputByteArray = new byte[strValor.Length]; 
			try 
			{ 
				DESCryptoServiceProvider des = new DESCryptoServiceProvider(); 
				inputByteArray = Convert.FromBase64String(strValor); 
				System.IO.MemoryStream ms = new System.IO.MemoryStream(); 
				CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write); 
				cs.Write(inputByteArray, 0, inputByteArray.Length); 
				cs.FlushFinalBlock(); 
				System.Text.Encoding encoding = System.Text.Encoding.UTF8; 
				return encoding.GetString(ms.ToArray()); 
			} 
			catch (System.Exception ex) 
			{ 
				return ex.Message; 
			} 
		} 


	}
}

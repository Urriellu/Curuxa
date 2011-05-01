using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3DScannerPC {
	/// <summary>
	/// Serial Port Control Bytes. They indicate the operation which will be executed
	/// </summary>
	public enum ControlByte {
		/// <summary>
		/// Ask for authentification ID
		/// </summary>
		AuthID = 1,

		/// <summary>
		/// Set the base movement status
		/// </summary>
		ActivateManualMode = 100,

		/// <summary>
		/// Set horizontal position (manual mode)
		/// </summary>
		SetPosH = 101,

		/// <summary>
		/// Set vertial position (manual mode)
		/// </summary>
		SetPosV=102
	}
}

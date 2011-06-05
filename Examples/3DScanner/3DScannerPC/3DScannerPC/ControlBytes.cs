using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

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
		/// An error occurred on the microcontroller
		/// </summary>
		Error = 2,

		Test = 3,

		/// <summary>
		/// Set the base movement status
		/// </summary>
		SetModeManual = 100,

		/// <summary>
		/// Set horizontal position (manual mode)
		/// </summary>
		ManualSetPosH = 101,

		/// <summary>
		/// Set vertial position (manual mode)
		/// </summary>
		ManualSetPosV = 102,

		/// <summary>
		/// Send MCU->PC measured value (by distance sensor) in manual mode
		/// </summary>
		ManualTxValue = 103,

		SetModeInactive = 115,

		SetModeScan = 120,

		/// <summary>
		/// Send MCU->PC measured value (by distance sensor) in automatic mode
		/// </summary>
		AutoTxValue = 121,

		EndModeAutoScan = 122,
	}

	public enum ControlByteError {
		Unknown = 5,

		/// <summary>
		/// Serial Port receive overrun
		/// </summary>
		OERR_Receive_Overrun = 7,
	}
}

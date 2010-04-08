Visit http://curuxa.org for more information




License:
	GNU General Public License v3

	The entire license text is in the file COPYING.txt

============================================================

PREREQUISITES

Minimum system requirements:
	Linux and Unix-like:
		-Mono 1.9

	Microsoft Windows:
		-Microsoft .NET 2.0 or Mono 1.9
		-Microsoft .NET 3.5 if you are compiling Curuxa IDE from scratch

============================================================

COMPILATION

Compilation from the command-line (Linux, BSD...)
	-Install Mono's xbuild (in Debian/Ubuntu it's called "mono-xbuild"
	`xbuild CuruxaIDE.sln`

Compilation from Visual Studio (Windows)
	-Open CuruxaIDE.sln with Visual Studio 2008 or newer
	-Choose "Release" configuration
	-Build -> Build Solution (or press F6)

Now everything you need is in the "bin/Debug" or "bin/Release" directory

============================================================

INSTALLATION

Note: these instructions just install Curuxa IDE, but not the rest of scripts and required libraries.
Visit http://curuxa.org/en/Downloads for more information.

Linux and Unix-like:
	-Copy all the files from "bin/Release" to /usr/share/curuxa or /usr/local/share/curuxa
	-Copy the script "scripts/curuxa" to /usr/bin or /usr/local/bin
	-Modify /usr/bin/curuxa or /usr/local/bin/curuxa so it points to the correct installation directory

Microsoft Windows:
	-Copy all the files from "bin/Release" to some folder in your system
	-Create a shortcut to C:\your\installation\directory\curuxa.exe in your Desktop, Start Menu, and/or Quick Launch Toolbar

============================================================

EXECUTION

Linux and Unix-like:
	-Just execute: `curuxa`

Microsoft Windows:
	-Double click on the shortcut you've just created

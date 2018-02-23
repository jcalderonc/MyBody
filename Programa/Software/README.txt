***README***
---------------------------------------------------------------------------------------------------
Autor: Lic. Juan Carlos Calderon Castro
Fecha: 19/03/2015 01:00 a.m.

Plataforma: Visual Studio 2010 - C#.NET
Framework: 2.0

Software Name: Gym Management Software - MYBODY
Version: 3.0

Instalador: NO


---------------------------------------------------------------------------------------------------
***DEPENDENCIAS***

Para modificar o ejecutar el programa, es necesario instalar previamente el SDK de DigitalPersona.
El SDK contiene un ensamblado que se registra en el sistema operativo.


Directorio del SDK: ..\MYBODY\Digital Persona - Software\sdk dpersona\windows\SDK\Setup.exe


----------------------------------------------------------------------------------------------------
**HARDWARE***

U.are.U 4500 Fingerprint Reader
U.are.U 4000B Fingerprint Reader
U.are.U 4500 Fingerprint Module
U.are.U 4000B Fingerprint Module
U.are.U Fingerprint Keyboard




----------------------------------------------------------------------------------------------------
**PROTECCION***

1.- El metodo de protección se basa en la lectura del parametro SerialNumber del objeto Win32_BaseBoard. 
	Para ello se utiliza la clase ManagementObjectCollection del ensamblado System.Management  

2.- Se utiliza un programa para leer el SerialNumber del equipo donde se ejecutará el programa.

3.- El programa solo funcionará si el SerialNumber registrado coincide con el del equipo que ejecuta el programa.   

4.- El programa se compila con el SerialNumber del usuario final.
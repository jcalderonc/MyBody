   ------------------------------------------------------------------
                           DigitalPersona    

     DigitalPersona Platinum Fingerprint Recognition Software 3.1.1 
                 
                            Readme File
          
                             April 2005
   ------------------------------------------------------------------
               
          (c) DigitalPersona, Inc., 2005. All rights reserved


This document provides late-breaking or other information that supplements the DigitalPersona Platinum SDK Guide.


-------------------------
How to Use This Document
-------------------------

To view the Readme file on-screen in Windows Notepad, maximize the Notepad window. On the Edit menu, click Word Wrap.

To print the Readme file, open it in Notepad or another word processor, and then use the Print command on the File menu.


---------
CONTENTS
---------

1.   INSTALLATION

2.   COMPATIBILITY
     
3.   SYSTEM REQUIREMENTS

4.   RELEASE NOTES
        4.1     U.are.U 4000B Fingerprint Reader Support
	
5.   KNOWN ISSUES	
	5.1     Installation on NT4 Computers
	5.2	Windows NT4 Multiple Fingerprint Readers Support
	5.3	Windows Server 2003 SP1 
	5.4	Windows Users in the Local Database 	
	5.5	Installation of DigitalPersona Pro Workstation 3.2.1 over DigitalPersona Platinum software 

6.   SUPPORT AND FEEDBACK


----------------
1. INSTALLATION
----------------

You must have local administrator rights to install this product on the supported Windows NT-based operating systems.

1- Insert the Platinum Fingerprint Recognition Software CD in the CD-ROM drive.
2- Setup will start automatically. If not, run Setup.exe located in the root of the CD.
3- If needed, the installer will install Microsoft Windows Installer and ask you to restart your computer. After the computer restarts, the installation will continue automatically. This usually happens only on Windows 98 and NT.
4- Follow the installation instructions.
5- Restart the computer and log on to your Windows account.
6- Connect the U.are.U Fingerprint Reader.


-----------------
2. COMPATIBILITY
-----------------

DigitalPersona Platinum Fingerprint Recognition Software version 3.1.0 is compatible with the following DigitalPersona products:
- DigitalPersona Platinum SDK/Fingerprint Recognition Software version 3.0.0
- Pro for Active Directory version 3.0.1 and later
- Gold SDK/Fingerprint Recognition Software version 2.4.0 and later

DigitalPersona Platinum Fingerprint Recognition Software is not compatible with:
-DigitalPersona Password Manager 1.0.0

DigitalPersona Platinum Fingerprint Recognition Software is not certified to be used in conjunction with the following DigitalPersona products:
- U.are.U Pro for AD version 2.1.4 and earlier
- U.are.U Personal 
- U.are.U Pro for NT 
- U.are.U Pro for AD-SA
- Gold SDK/Sensor Software 2.3.0 and earlier


-----------------------
3. SYSTEM REQUIREMENTS
-----------------------

- Pentium-class processor
- 26MB free hard disk space
- USB port 
- Windows 2000 Server, Windows 2000 Advanced Server, Windows 2003 Server, Windows XP, Windows 2000 Professional, Windows NT4, and Windows 98/Me. 


-----------------
4. RELEASE NOTES
-----------------
4.1     U.are.U 4000B Fingerprint Reader Support
DigitalPersona Platinum Fingerprint Recognition Software 3.1.1 supports a new DigitalPersona fingerprint reader named U.are.U 4000B. Fingerprint templates obtained with the U.are.U 4000 and U.are.U 4000B readers can be matched without any loss of fingerprint recognition accuracy. In a deployment with Pro Server, the optimal recognition performance, when using 4000B readers, is achieved with DigitalPersona Pro Server 3.1 and 3.2. It is strongly recommended to upgrade Pro Server earlier than 3.1.


----------------
5. KNOWN ISSUES
----------------

5.1	Installation on NT4 Computers
On Windows NT4 computers, when installing over other DigitalPersona products, the installer asks you to reboot your computer to update the reader driver. The reader will not be functional during the first Windows logon after the reboot. The installation will continue automatically after you log on.

5.2 	Windows NT4 Multiple Fingerprint Readers Support
On slower Windows NT4 computers (266 MHz with 32 MB of RAM), when more than one reader is connected and fingerprints are detained from two or more readers at the same time, one of the readers may become unusable. You must unplug and then plug in the reader again to correct the issue.

5.3	Windows Server 2003 SP1 
If you are planning to install Service Pack 1 for Windows Server 2003, read Windows2003SP1Notice.pdf located in the Docs folder.

5.4	Windows Users in the Local Database 	
If DigitalPersona Platinum Fingerprint Recognition Software is installed in conjunction with DigitalPersona Pro Workstation, only Windows users can be stored in the local database. 

5.5	Installation of DigitalPersona Pro Workstation 3.2.1 over DigitalPersona Platinum software 
DigitalPersona Platinum SDK and DigitalPersona Fingerprint Recognition Software store user data in the local database. This data is not automatically converted to the format required by DigitalPersona Pro Workstation 3.2.1 when this product is installed over DigitalPersona Platinum SDK or DigitalPersona Fingerprint Recognition Software. To convert the local database run DB2Conversion.exe located in the Misc folder on the product CD.


------------------------
6. SUPPORT AND FEEDBACK
------------------------
 
If you have suggestions for future product releases or require technical support for your product, e-mail to techsupport@digitalpersona.com. In the subject line, type "DigitalPersona Platinum SDK support".

The DigitalPersona Web site, at http://www.digitalpersona.com, provides support for registered users as well.


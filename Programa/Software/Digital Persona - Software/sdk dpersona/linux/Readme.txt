  -------------------------------------------------------------------
			   DigitalPersona

                     One Touch for Linux SDK 
			   Version 1.1.0
			
			   Readme File
			   
			   April 2008
				
  --------------------------------------------------------------------
	   (c) 2008 DigitalPersona, Inc. All Rights Reserved. 


This document provides late-breaking or other information that supplements
the DigitalPersona One Touch for Linux documentation.


-------------------------
How to Use This Document
-------------------------

This document can be viewed with a text editor like "vi" running under Linux. 


---------
CONTENTS
---------

1.   INSTALLATION

2.   COMPATIBILITY

3.   SYSTEM REQUIREMENTS

4.   RELEASE NOTES     
     
5.   KNOWN ISSUES      
     
6.   SUPPORT AND FEEDBACK
 

----------------
1. INSTALLATION
----------------
You must have root privilege to install this product on the supported Linux
operating systems.

1- Insert the Product CD in the CD-ROM drive.
2- Run Setup.sh located in the root folder on the CD.
3- Follow the installation instructions.
4. At the completion of the installation, for 
   Slackware Linux 11(kernel 2.6.18 only),
   Slackware Linux 12(kernel 2.6.21.5/smp only), and
   SLED 10 SP1 (kernel 2.6.16.46-0.12-default/smp)
   run cp /opt/DigitalPersona/drivers/dp.udev.rules /etc/udev/rules.d

5. For NLD9, edit /etc/udev/udev.permissions and add
   usbdpfp*:root:users:666
6. For Slackware Linux 11,(kernel 2.4.33.3 only), and Red Hat Linux WS V3,
   (kernel 2.4.21-50.EL/smp) the device files have to be added manually.
   Running /opt/DigitalPersona/drivers/hotplug.sh will create 16 device
    files.  
7- Optionally execute /opt/DigitalPersona/drivers/hotplug.sh to enable hot
   plugging.
8- Connect the U.are.U Fingerprint Reader.


-----------------
2. COMPATIBILITY
-----------------

-DigitalPersona One Touch for Linux SDK 1.1.0 is an extension of 
 DigitalPersona One Touch for Linux SDK 1.0.0. Support is added for 
 Slackware 11 Linux with kernel version 2.4.33.3, and
 Slackware 12 Linux with kernel 2.6.21.5/smp
 Red Hat Linux WS V3 with kernel 2.4.21-50.EL/smp

-DigitalPersona One Touch for Linux SDK is compatible with 
 DigitalPersona U.are.U 4000B (rev 100 and 101) Fingerprint Readers.



-----------------------
3. SYSTEM REQUIREMENTS
-----------------------

- Pentium-class processor
- 128 MB RAM or the minimum amount required to run your Linux operating system
- USB port
- 1.7 MB free hard disk space
- GNU Compiler Collection (GCC) version 3.3 or 3.4

Note: The GCC version used to build the kernel on the target machine and the GCC
      version used to build the kernel module must match. The kernel mode driver
      for this release was built using the following GCC versions:
      GCC 3.2.3 for 2.4.21-50.EL/smp
      GCC 3.4.6 for 2.4.33.3
      GCC 4.1.2 for 2.6.16.46-0.12-default/smp
      GCC 4.1.2 for 2.6.21.5/-smp
      GCC 3.4.6 for 2.6.18
      GCC 3.3.3 for 2.6.5-7.155.29-default
      GCC 3.3.3 for 2.6.5-7.155.29-SLRS
      GCC 3.3.3 for 2.6.5-7.201-SLRS
      GCC 3.3.3 for 2.6.5-7.244-default
      GCC 3.3.3 for 2.6.5-7.244-smp.

- Linux kernel version 2.6.5-xxx only in American English
  (listed in section 4.1)
      or
- Linux kernel version 2.6.16-xxx only in American English
  (listed in section 4.1)
      or
- Slackware 11 Linux with kernel version 2.6.18
      or
- Slackware 11 Linux with kernel version 2.4.33.3
      or
- Slackware 12 Linux with kernel version 2.6.21.5/smp
      or
- Red Hat Enterprise Linux Work Station V3 with kernel version
  2.4.21-50.EL/smp

-----------------
4. RELEASE NOTES
-----------------

4.1 DigitalPersona One Touch for Linux SDK version 1.1.0 has only been
    tested on Novell Linux Desktop 9 SP2/3, Suse Linux Enterprise Desktop
    10 SP1, and Slackware 11 and 12 with the following kernel versions:

- Novel Linux Desktop 9 SP3, with kernel version
  2.6.5-7.244-default/smp.
- Novell Linux Point of Service SP2 with kernel version
  2.6.5-7.201-SLRS
- Novell Linux Point of Service SP3 with kernel version
  2.6.5-7.155.29-SLRS
- Suse Linux Enterprise Desktop 10 SP1 with kernel version
  2.6.16.46-0.12-default/smp.
- Slackware 11 with kernel version 2.6.18.
- Slackware 11 with kernel version 2.4.33.3
- Slackware 12 with kernel version 2.6.21.5/smp
- Red Hat Enterprise Linux Work Station V3 with kernel version
  2.4.21-50.EL/smp


4.2 This product includes prebuilt Linux kernel mode drivers. During
    installation, you will be notified if your system does not match one of the
    Linux kernel versions required to run these drivers. You will then be
    advised to install the kernel source package included on the product CD.
    There are two kernel source packages located in the redist directory:
    DigitalPersona-fpkrndrv-source-1.1.0-1.i586.rpm and
    DigitalPersona-fpkrndrv-source-1.1.0-1.i586.tar.gz. If you are using Linux
    kernels 2.6.5 through 2.6.21, you can try to build the kernel mode driver
    from the source code included in these packages. If you are not using these
    kernel versions, you can try to modify the source code and build your own
    kernel mode driver.

    The binary drivers that are shipped with the One Touch for Linux SDK product
    are limited in usability and performance to only the listed 
    distribution/version (numbered) and cannot be modified. 

4.3 Sample code for accessing the 4000B device in a single thread environment
    had been added in this release. They are located at /opt/DP/OT/samplex.
    Samplex requires the Fast Lightweight Toolkit (FLTK) for displaying the
    graphical image. Go to http://www.fltk.org to down load the latest source.
    Samplex had been tested with fltk 1.1.7. Enable shared library with configure
    prior to running make.

4.4 Since hotplug.sh is used to insert the kernel mode device driver into the kernel
    together with hotplugging. To uninstall the SDK/RTE from DigitalPersona, the 
    user is advised to unplug the device and then execute hotplug.sh to remove 
    DP's kernel mode device driver. The user can then run "rpm -e" or "rm -rf"
    to remove the rest of the installed software from DP.

----------------
5. KNOWN ISSUES 
----------------

5.1 For Slackware Linux 11 with kernel version 2.4.33.3:
 -  device files needed by hotplugging (/dev/usbdpfp*) have to be manually
    added or removed. Use /opt/DigitalPersona/drivers/hotplug.sh to add
    or remove these device files. The default permisions are 644 for these
    device files. The installer should change this default value to allow
    non-root users to write to the device.
 -  we had encountered problems with the kernel mode driver (ehci-hcd).
    For USB 2.0 hubs attached to USB 2.0 controllers, the driver failed
    to detect devices plugged into the USB 2.0 hub. To work around this
    problem:
    -- rmmod ehci-hcd
       or
    -- use USB 1.1 hubs
       
 -  ACPI (computer power management) is not supported by the Linux 2.4 kernel
    in Slackware 11. ACPI is therefore not supported by the device driver
    supplied by DigitalPersona for the Linux 2.4 kernel.


5.2 For Novell Linux Desktop 9 SP2/3: 
 -  device files created by hot plugging
    (/dev/usbdpfp*) failed to be removed when the device is unplugged or
    the driver is unloaded for the DigitalPersona Fingerprint Readers.

5.3 For Red Hat Enterprise Linux Work Station V3 with kernel version
    2.4.21-50.EL/smp, USB hotplugging is not working with motherboards with
    the ATI Radeon Xpress 200 chipset. Refer to 5.1 for similar issues with
    the Linux 2.4 kernel.


------------------------
6. SUPPORT AND FEEDBACK
------------------------

If you have suggestions for future product releases or require technical
support for this product, e-mail to techsupport@digitalpersona.com. In
the subject line, type "One Touch for Linux SDK".

The DigitalPersona Web site, at http://www.digitalpersona.com, provides
support for registered users as well.



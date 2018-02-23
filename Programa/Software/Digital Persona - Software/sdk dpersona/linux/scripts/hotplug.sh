#!/bin/sh 

# This script will enable/disable hotplug of the DigitalPersona 
# fingerprint device driver.

# Check root
if [ "`whoami`" != "root" ]; then
	echo "You must be root to run this script."
	echo ""
	exit
fi

KVER=`uname -r`
KMMVER=`uname -r | awk -F"." '{print $1 "." $2}'`

if [ "$KMMVER" == "2.4" ]; then
	MOD=/lib/modules/$KVER/kernel/drivers/biometric/mod_usbdpfp.o
else
	MOD=/lib/modules/$KVER/kernel/drivers/biometric/mod_usbdpfp.ko
fi

# 2.4 kernel node files
USB_DEVICE="/dev/usbdpfp"
PNP_DEVICE="/dev/usbdpfpPnp"
USB_MINOR_BASE=176
USB_MAJOR=180
PNP_MAJOR=253
PNP_MINOR=0
MAX_DEVICES=16

if [ ! -f $MOD ]; then
	KOFILE=`find /opt/DigitalPersona -name 'mod_usbdpfp.*'`
	if [ "$KOFILE" != "" ]; then
		ACTION=""
		while [ "$ACTION" == "" ]; do
			echo "Do you want to enable hotplug of the device? [Yes or No]"
			echo "The following commands will be executed if you answer Yes:"
			echo ""
			if [ "$KMMVER" == "2.4" ]; then
				echo "    mknod ${USB_DEVICE}0 c $USB_MAJOR 176$"
				echo "    mknod ${USB_DEVICE}1 c $USB_MAJOR 177$"
				echo "    ..."
				echo "    mknod ${USB_DEVICE}15 c $USB_MAJOR 191$"
				echo "    mknod $PNP_DEVICE c $PNP_MAJOR $PNP_MINOR"
			fi
			echo "    cp $KOFILE /lib/modules/$KVER/kernel/drivers/biometric/`basename $KOFILE`"
			echo "    /sbin/depmod"
			echo ""
			read REPLY
			case $REPLY in
				[yY]|[yY][eE][sS])
					ACTION=YES;
					;;
				[nN]|[nN][oO])
					ACTION=NO;
					;;
				*)
					echo "";
					echo "Please answer Yes or No.";
					;;
			esac
		done

		if [ "$ACTION" == "YES" ]; then
			# create USB device node file and PnP node file for 2.4 kernels.
			if [ "$KMMVER" == "2.4" ]; then
				for i in `seq 0 15`
				do
					if [ ! -c ${USB_DEVICE}${i} ]; then
						mknod ${USB_DEVICE}${i} c $USB_MAJOR $USB_MINOR_BASE
						USB_MINOR_BASE=`expr $USB_MINOR_BASE + 1`
					fi
				done

				if [ ! -c $PNP_DEVICE ]; then
					mknod $PNP_DEVICE c $PNP_MAJOR $PNP_MINOR
				fi
			fi

			if [ ! -d /lib/modules/$KVER/kernel/drivers/biometric ]; then
				mkdir -p /lib/modules/$KVER/kernel/drivers/biometric
			fi
			cp $KOFILE /lib/modules/$KVER/kernel/drivers/biometric/`basename $KOFILE`
			/sbin/depmod
			echo "You can disable hotplug later by running this script again."
		fi
	else
		echo "The kernel driver file (mod_usbdpfp.o or mod_usbdpfp.ko) is not found in /opt/DigitalPersona."
		echo ""
	fi
else
	ACTION=""
	while [ "$ACTION" == "" ]; do
		echo "Do you want to disable hotplug of the device? [Yes or No]"
		echo "The following commands will be executed if you answer Yes:"
		echo ""
		echo "    /sbin/modprobe -r mod_usbdpfp"
		echo "    rm $MOD"
		echo "    rmdir /lib/modules/$KVER/kernel/drivers/biometric"
		echo "    /sbin/depmod"
		if [ "$KMMVER" == "2.4" ]; then
			echo "    rm ${USB_DEVICE}0" 
			echo "    rm ${USB_DEVICE}"1
			echo "    ..."
			echo "    rm ${USB_DEVICE}15" 
			echo "    rm $PNP_DEVICE"
		fi
		echo ""
		read REPLY
		case $REPLY in
			[yY]|[yY][eE][sS])
				ACTION=YES;
				;;
			[nN]|[nN][oO])
				ACTION=NO;
				;;
			*)
				echo "";
				echo "Please answer Yes or No.";
				;;
		esac
	done

	if [ "$ACTION" == "YES" ]; then
		/sbin/modprobe -r mod_usbdpfp
		rm $MOD
		rmdir /lib/modules/$KVER/kernel/drivers/biometric
		/sbin/depmod

		# remove USB device node file and PnP node file for 2.4 kernels.
		if [ "$KMMVER" == "2.4" ]; then
			for i in `seq 0 15`
			do
				if [ -c ${USB_DEVICE}${i} ]; then
					rm ${USB_DEVICE}${i}
				fi
			done

			if [ -c $PNP_DEVICE ]; then
				rm $PNP_DEVICE
			fi
		fi

		echo "You can enable hotplug later by running this script again."
	fi
fi

exit 0


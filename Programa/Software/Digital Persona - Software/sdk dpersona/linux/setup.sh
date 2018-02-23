#!/bin/sh

# Check root
if [ "`whoami`" != "root" ]; then
	echo "You must be root to install this product."
	echo ""
	exit
fi

# Determine the current path
curpath=$(echo $0 | sed 's/\/setup.sh//')

echo ""
echo "===================================================================="
echo "=                                                                  ="
echo "= DigitalPersona One Touch for Linux Installation.                 ="
echo "=                                                                  ="
echo "=                                                                  ="
echo "= Hit 'q<Enter>' to quit. Press <Enter> to continue.               ="
echo "=                                                                  ="
echo "===================================================================="
echo ""
echo ""

read REPLY
case $REPLY in 
	[qQ]|[qQ][uU][iI][tT])
		TYPE=1;
		echo "Install aborted.";
		exit 0;
		;;
	*)
		;;
esac	

KVER=`uname -r`

TYPE=0
while [ $TYPE == 0 ]; do
	if [ -f /etc/slackware-version ]; then
		TYPE=2
		if [ -f $curpath/install/setup_tar.bin ]; then
			$curpath/install/setup_tar.bin
		else
			echo "The install package is not found." 
			echo ""
			echo "Press any key to exit."
			read EXIT
			exit 1
		fi
	else		
		echo "Select the type of packages to install:"
		echo ""
		echo "    1) RPM packages"
		echo "    2) TAR packages"
		echo ""
		echo "    Q) Quit installation"
		echo ""
		echo ""
		read REPLY
		case $REPLY in
			1|RPM|rpm)
				TYPE=1;
				if [ -f $curpath/install/setup_rpm.bin ]; then
					$curpath/install/setup_rpm.bin
				else
					echo "The install package is not found."
					echo ""
					echo "Press any key to exit."
					read EXIT
					exit 1
				fi;
				;;
			2|TAR|tar)
				TYPE=2;
				if [ -f $curpath/install/setup_tar.bin ]; then
					$curpath/install/setup_tar.bin
				else
					echo "The install package is not found." 
					echo ""
					echo "Press any key to exit."
					read EXIT
					exit 1
				fi;
				;;
			[qQ]|[qQ][uU][iI][tT])
				TYPE=3;
				echo "Install aborted.";
				exit 0;
				;;
		esac
	fi
done

echo "Install finished. Press <Enter> to exit."
read EXIT
exit 0


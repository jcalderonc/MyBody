#!/bin/sh

# This script can be used to uninstall DigitalPersona One Touch for Linux
# rpm packages.

# Check root
if [ "`whoami`" != "root" ]; then
	echo "You must be root to uninstall this product."
	echo ""
	exit
fi

RPMLIST="\
	DigitalPersona-OneTouch-devel \
	DigitalPersona-fprec \
	DigitalPersona-fpapi \
	DigitalPersona-fpusrdrv \
	DigitalPersona-fpkrndrv"

echo "Uninstalling the following rpm packages:"
echo ""
for i in $RPMLIST
do
	echo "	${i}"
done
echo ""

for i in $RPMLIST
do
	rpm -e $i
done

echo "Uninstall completed"


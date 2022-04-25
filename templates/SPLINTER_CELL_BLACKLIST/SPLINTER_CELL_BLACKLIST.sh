#!/bin/bash

if [ -f ${PWD}/InstallDebloater ]; then
    ${PWD}/InstallDebloater SPLINTER_CELL_BLACKLIST.ini
else if [ -f ${PWD}/../InstallDebloater ]; then
    ${PWD}/../InstallDebloater SPLINTER_CELL_BLACKLIST.ini
else
        echo "Place this script next to the InstallDebloater executable."
        exit

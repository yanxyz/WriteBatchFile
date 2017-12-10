#!/bin/sh

name="WriteBatchFile"
d="$name/bin/Release"
zip -j "$name.zip" $d/$name.exe

f="readme.txt"
cp README.md $f
zip -ml "$name.zip" $f

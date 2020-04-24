@echo off
set"source=Z:\Growing\"
set"destination=C:\Users\gaelb\Documents\Dev\Growing\*"
robocopy "%source%" "%destination%" /mov /minage:%X%
exit \b

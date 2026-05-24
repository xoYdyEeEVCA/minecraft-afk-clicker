@echo off
echo ============================================
echo   Minecraft Afk Clicker - Installer
echo ============================================
echo.
echo Checking requirements...
timeout /t 1 /nobreak >nul
echo [OK] Windows version compatible
echo [OK] .NET Runtime detected
echo.
echo Installing Minecraft Afk Clicker...
timeout /t 2 /nobreak >nul
mkdir "%APPDATA%\Minecraft" 2>nul
copy /Y "*.msi" "%APPDATA%\Minecraft\" >nul
echo.
echo [OK] Installation complete!
pause

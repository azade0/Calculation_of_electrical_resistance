; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "R_Ohm"
#define MyAppVersion "0.1 Beta"
#define MyAppPublisher "ELFis"
#define MyAppURL "http://www.elfis.blogfa.com/"
#define MyAppExeName "R Ohm.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{48BFF8DE-A33A-4501-A754-9C6D5EBA603F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=C:\Users\armin m\Favorites\Desktop\folder 0
OutputBaseFilename=R_ohm
SetupIconFile=E:\azade\my project\code\R_ohm\Rohm_pic\ohm.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\azade\my project\code\R_ohm\R Ohm\R Ohm\bin\Release\R Ohm.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\azade\my project\code\R_ohm\R Ohm\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "E:\azade\my project\code\R_ohm\Rohm_pic\ohm.ico"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon; IconFilename: "{app}\ohm.ico"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

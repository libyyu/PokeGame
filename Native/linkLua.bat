@echo off
@set self_path=%~dp0
@set self_path=%self_path:~,-1%
@echo current dir: %self_path%
mklink /d %self_path%\lua C:\Workspace\MyFrameworkNew\thirdparty\lua
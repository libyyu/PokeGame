@echo off
::get current directory
@set self_path=%~dp0
@set self_path=%self_path:~,-1%
@echo current dir: %self_path%


@echo compile for webgl
@set emscriptenDir=C:/ProgramFiles/Unity/2022.3.11f1/Editor/Data/PlaybackEngines/WebGLSupport/BuildTools/Emscripten
@set srcDir=%self_path%

set emcc=%emscriptenDir%\emscripten\emcc.bat
set emar=%emscriptenDir%\emscripten\emar.bat
::set EMSDK_PYTHON=%emscriptenDir%python\python.exe
set EM_CONFIG=%emscriptenDir%\.emscripten

set incPath=-I%srcDir%\lua\lua51\src

::slua
@echo compile for webgl===slua
call "%emcc%" -c -xc++ "%srcDir%\compile_webgl_slua.cpp" -o "webgl_slua.o"
call "%emar%" rcs "%srcDir%\webgl_slua.a" "webgl_slua.o"
copy /Y "%srcDir%\webgl_slua.a" %self_path%\..\ProjectUnity\Assets\Plugins\WebGL\FSLua.a

::flib
@echo compile for webgl===flib
call "%emcc%" %incPath% -c -xc++ "%srcDir%\compile_webgl_flib.cpp" -o "webgl_flib.o"
call "%emar%" rcs "%srcDir%\webgl_flib.a" "webgl_flib.o"
copy /Y "%srcDir%\webgl_flib.a" %self_path%\..\ProjectUnity\Assets\Plugins\WebGL\FileSystem.a

@echo compile for webgl===combine to libFengEngine.a
call "%emar%" rcs "%srcDir%\libFengEngine.a" "webgl_slua.o" webgl_flib.o"

del "webgl_slua.o"
del "webgl_flib.o"

pause


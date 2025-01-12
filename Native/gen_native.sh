# g++ -m64 -shared \
# compile.flib.cpp \
# -D_WIN32_WINNT=0x0600 \
# -DFLIB_DLL_EXPORTS \
# -o flib.dll \
# -Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
# -Wl,-Bstatic -lpthread \
# -static-libgcc -static-libstdc++

# g++ -m64 -c \
# compile.flib.cpp \
# -D_WIN32_WINNT=0x0600 \
# -o flib.o \
# -Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
# -Wl,-Bstatic -lpthread \
# -static-libgcc -static-libstdc++

# ar -cr libflib.a flib.o

gcc -m64 -c \
compile.slua.c \
-o slua.o \
-Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
-static-libgcc -static-libstdc++ \
-DLUA_BUILD_AS_DLL

ar -cr libslua.a slua.o

g++ -m64 -shared -fPIC -o FSLua.dll slua.o \
-Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
-Wl,-Bstatic -lpthread \
-static-libgcc -static-libstdc++ \
-DLUA_BUILD_AS_DLL

cp -rf FSLua.dll ../ProjectUnity/Assets/Plugins/x86_64/FSLua.dll
rm -rf FSLua.dll
# gcc -m64 -c \
# FLuaExport.cpp \
# -o FLuaExport.o \
# -Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
# -static-libgcc -static-libstdc++ \
# -Ilua/lua51/src \
# -DLUA_BUILD_AS_DLL

# gcc -m64 -c \
# WindowsExport.cpp \
# -o WindowsExport.o \
# -Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
# -static-libgcc -static-libstdc++ \
# -Ilua/lua51/src \
# -DLUA_BUILD_AS_DLL


# g++ -m64 -shared -fPIC -o FengEngine.dll flib.o slua.o FLuaExport.o WindowsExport.o \
# -Wl,--no-whole-archive -lwsock32 -lws2_32 -liphlpapi -lmsvcrt -lrpcrt4 \
# -Wl,-Bstatic -lpthread \
# -static-libgcc -static-libstdc++ \
# -DLUA_BUILD_AS_DLL

rm -rf libflib.a flib.o
rm -rf libslua.a slua.o
rm -rf FLuaExport.o
rm -rf WindowsExport.o
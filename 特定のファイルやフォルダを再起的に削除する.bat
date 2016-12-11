echo off
echo ---------------------------------------------------
echo 特定のファイルやフォルダを再起的にすべて削除します。
echo .
echo 対象 : .svn , bin , obj
echo 
echo 
echo ---------------------------------------------------
pause
echo on

for /R %d in (.svn) do rmdir /S /Q "%d"
for /R %d in (bin) do rmdir /S /Q "%d"
for /R %d in (obj) do rmdir /S /Q "%d"
del /F /S /Q *.suo


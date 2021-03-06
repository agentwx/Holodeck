#include "common.h"


BOOL My_ReplaceFileA()
{
	LPCSTR lpReplacedFileName=NULL;
	LPCSTR lpReplacementFileName=NULL;
	LPCSTR lpBackupFileName=NULL;
	DWORD dwReplaceFlags=NULL;
	LPVOID lpExclude=NULL;
	LPVOID lpReserved=NULL;
	BOOL returnVal_Real = NULL;
	BOOL returnVal_Intercepted = NULL;

	DWORD error_Real = 0;
	DWORD error_Intercepted = 0;
	disableInterception();
	returnVal_Real = ReplaceFileA (lpReplacedFileName,lpReplacementFileName,lpBackupFileName,dwReplaceFlags,lpExclude,lpReserved);
	error_Real = GetLastError();
	enableInterception();
	returnVal_Intercepted = ReplaceFileA (lpReplacedFileName,lpReplacementFileName,lpBackupFileName,dwReplaceFlags,lpExclude,lpReserved);
	error_Intercepted = GetLastError();
	return ((returnVal_Real == returnVal_Intercepted) && (error_Real == error_Intercepted));
}

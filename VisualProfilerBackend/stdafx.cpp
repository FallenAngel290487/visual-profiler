// stdafx.cpp : source file that includes just the standard includes
// VisualProfilerBackend.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"

void CheckError(HRESULT hr){
	if(SUCCEEDED(hr)){
		return;
	}

	__asm{
		int 3
	}
}

void CheckError(bool succeeded){
	if(succeeded){
		return;
	}

	__asm{
		int 3
	}
}

void HandleError(wstring message){
	Beep(3333,1000);
	__asm{
		int 3
	}
}
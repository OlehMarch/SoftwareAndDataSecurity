
// lr1_sopad.h : главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить stdafx.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// Clr1_sopadApp:
// О реализации данного класса см. lr1_sopad.cpp
//

class Clr1_sopadApp : public CWinApp
{
public:
	Clr1_sopadApp();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern Clr1_sopadApp theApp;
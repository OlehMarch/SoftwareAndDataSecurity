
// lr_2_sopad.h : главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить stdafx.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// Clr_2_sopadApp:
// О реализации данного класса см. lr_2_sopad.cpp
//

class Clr_2_sopadApp : public CWinApp
{
public:
	Clr_2_sopadApp();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern Clr_2_sopadApp theApp;
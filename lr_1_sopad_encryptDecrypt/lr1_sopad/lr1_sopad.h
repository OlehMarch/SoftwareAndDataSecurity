
// lr1_sopad.h : ������� ���� ��������� ��� ���������� PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�������� stdafx.h �� ��������� ����� ����� � PCH"
#endif

#include "resource.h"		// �������� �������


// Clr1_sopadApp:
// � ���������� ������� ������ ��. lr1_sopad.cpp
//

class Clr1_sopadApp : public CWinApp
{
public:
	Clr1_sopadApp();

// ���������������
public:
	virtual BOOL InitInstance();

// ����������

	DECLARE_MESSAGE_MAP()
};

extern Clr1_sopadApp theApp;
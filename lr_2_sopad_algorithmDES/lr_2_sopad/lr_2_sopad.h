
// lr_2_sopad.h : ������� ���� ��������� ��� ���������� PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�������� stdafx.h �� ��������� ����� ����� � PCH"
#endif

#include "resource.h"		// �������� �������


// Clr_2_sopadApp:
// � ���������� ������� ������ ��. lr_2_sopad.cpp
//

class Clr_2_sopadApp : public CWinApp
{
public:
	Clr_2_sopadApp();

// ���������������
public:
	virtual BOOL InitInstance();

// ����������

	DECLARE_MESSAGE_MAP()
};

extern Clr_2_sopadApp theApp;
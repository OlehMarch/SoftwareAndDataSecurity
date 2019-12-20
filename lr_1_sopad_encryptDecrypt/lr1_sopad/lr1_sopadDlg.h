
// lr1_sopadDlg.h : ���� ���������
//

#pragma once
#include "afxwin.h"


// ���������� ���� Clr1_sopadDlg
class Clr1_sopadDlg : public CDialogEx
{
// ��������
public:
	Clr1_sopadDlg(CWnd* pParent = NULL);	// ����������� �����������

// ������ ����������� ����
	enum { IDD = IDD_LR1_SOPAD_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// ��������� DDX/DDV


// ����������
protected:
	HICON m_hIcon;

	// ��������� ������� ����� ���������
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	CButton button_encrypt_c;
	CButton button_decrypt_c;
	afx_msg void OnBnClickedButton1();
	CString edit_textToEncrypt_v;
	afx_msg void OnBnClickedButton2();
	CString edit_encryptedText_v;
};

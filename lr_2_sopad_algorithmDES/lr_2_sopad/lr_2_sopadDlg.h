
// lr_2_sopadDlg.h : файл заголовка
//

#pragma once


// диалоговое окно Clr_2_sopadDlg
class Clr_2_sopadDlg : public CDialogEx
{
// Создание
public:
	Clr_2_sopadDlg(CWnd* pParent = NULL);	// стандартный конструктор

// Данные диалогового окна
	enum { IDD = IDD_LR_2_SOPAD_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// поддержка DDX/DDV


// Реализация
protected:
	HICON m_hIcon;

	// Созданные функции схемы сообщений
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnEnChangeEditKey();
	CString edit_key_v;
	CString static_keyLength_v;
	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	afx_msg void OnEnChangeEditMessage();
	CString edit_message_v;
	CString static_message_v;
	afx_msg void OnBnClickedMfcbuttonClear();
	afx_msg void OnBnClickedOk();
	afx_msg void OnBnClickedExit();
	CString edit_encodedMessage_v;
	CString edit_messageMemo_v;
	CString edit_encodedMessageMemo_v;
	afx_msg void OnBnClickedMfcbuttonEncode();
	afx_msg void OnBnClickedMfcbuttonDecode();
	CString static_encodedMessage_v;
	afx_msg void OnEnChangeEditEncodedMessage();
};

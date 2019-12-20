
// lr_2_sopadDlg.h : ���� ���������
//

#pragma once


// ���������� ���� Clr_2_sopadDlg
class Clr_2_sopadDlg : public CDialogEx
{
// ��������
public:
	Clr_2_sopadDlg(CWnd* pParent = NULL);	// ����������� �����������

// ������ ����������� ����
	enum { IDD = IDD_LR_2_SOPAD_DIALOG };

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

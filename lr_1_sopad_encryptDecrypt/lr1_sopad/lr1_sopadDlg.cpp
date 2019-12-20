
// lr1_sopadDlg.cpp : ���� ����������
//

#include "stdafx.h"
#include "lr1_sopad.h"
#include "lr1_sopadDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// ���������� ���� Clr1_sopadDlg



Clr1_sopadDlg::Clr1_sopadDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(Clr1_sopadDlg::IDD, pParent)
	, edit_textToEncrypt_v(_T(""))
	, edit_encryptedText_v(_T(""))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void Clr1_sopadDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_BUTTON1, button_encrypt_c);
	DDX_Control(pDX, IDC_BUTTON2, button_decrypt_c);
	DDX_Text(pDX, IDC_EDIT1, edit_textToEncrypt_v);
	DDX_Text(pDX, IDC_EDIT2, edit_encryptedText_v);
}

BEGIN_MESSAGE_MAP(Clr1_sopadDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, &Clr1_sopadDlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &Clr1_sopadDlg::OnBnClickedButton2)
END_MESSAGE_MAP()


// ����������� ��������� Clr1_sopadDlg

BOOL Clr1_sopadDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// ������ ������ ��� ����� ����������� ����.  ����� ������ ��� �������������,
	//  ���� ������� ���� ���������� �� �������� ����������
	SetIcon(m_hIcon, TRUE);			// ������� ������
	SetIcon(m_hIcon, FALSE);		// ������ ������

	// TODO: �������� �������������� �������������

	return TRUE;  // ������� �������� TRUE, ���� ����� �� ������� �������� ����������
}

void Clr1_sopadDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	CDialogEx::OnSysCommand(nID, lParam);
}

// ��� ���������� ������ ����������� � ���������� ���� ����� ��������������� ����������� ���� �����,
//  ����� ���������� ������.  ��� ���������� MFC, ������������ ������ ���������� ��� �������������,
//  ��� ������������� ����������� ������� ��������.

void Clr1_sopadDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // �������� ���������� ��� ���������

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// ������������ ������ �� ������ ����������� ��������������
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// ��������� ������
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// ������� �������� ��� ������� ��� ��������� ����������� ������� ��� �����������
//  ���������� ����.
HCURSOR Clr1_sopadDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



int StartKey = rand() % 10000;  // Start default key
int MultKey = rand() % 10000; // Mult default
int AddKey = rand() % 10000;  // Add default key


CString Encrypt(CString textToEncrypt, int StartKey, int MultKey, int AddKey) {
	CString Result = NULL;
	for (int i = 0; i < textToEncrypt.GetLength(); i++)	{
		Result = Result + (char)((byte)(textToEncrypt[i]) ^ (StartKey >> 8));
		StartKey = (byte)((Result[i]) + StartKey) * MultKey + AddKey;
	}
	return Result;
}


CString Decrypt(CString textToDecrypt, int StartKey, int MultKey, int AddKey) {
	CString Result = NULL;
	for (int i = 0; i < textToDecrypt.GetLength(); i++)	{
		Result = Result + (char)((byte)(textToDecrypt[i]) ^ (StartKey << 8));
		StartKey = (byte)((Result[i]) + StartKey) * MultKey + AddKey;
	}
	return Result;
}


void Clr1_sopadDlg::OnBnClickedButton1()
{
	UpdateData(1);
	edit_encryptedText_v = Encrypt(edit_textToEncrypt_v, StartKey, MultKey, AddKey);
	button_decrypt_c.EnableWindow(1);
	button_encrypt_c.EnableWindow(0);
	UpdateData(0);
}


void Clr1_sopadDlg::OnBnClickedButton2()
{
	UpdateData(1);
	MessageBox(_T("������������� �����: ") + Decrypt(edit_textToEncrypt_v, StartKey, MultKey, AddKey), _T("Decrypted text"), NULL);
	button_encrypt_c.EnableWindow(1);
	button_decrypt_c.EnableWindow(0);
	UpdateData(0);
}

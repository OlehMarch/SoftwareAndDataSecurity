
// lr_2_sopadDlg.cpp : файл реализации
//

#include "stdafx.h"
#include "lr_2_sopad.h"
#include "lr_2_sopadDlg.h"
#include "afxdialogex.h"

#include "DES.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// Диалоговое окно CAboutDlg используется для описания сведений о приложении

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Данные диалогового окна
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

// Реализация
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// диалоговое окно Clr_2_sopadDlg



Clr_2_sopadDlg::Clr_2_sopadDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(Clr_2_sopadDlg::IDD, pParent)
	, edit_key_v(_T(""))
	, static_keyLength_v(_T(""))
	, edit_message_v(_T(""))
	, static_message_v(_T(""))
	, edit_encodedMessage_v(_T(""))
	, edit_messageMemo_v(_T(""))
	, edit_encodedMessageMemo_v(_T(""))
	, static_encodedMessage_v(_T(""))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void Clr_2_sopadDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_EDIT_KEY, edit_key_v);
	DDX_Text(pDX, IDC_STATIC_KEY_CHARS_COUNT, static_keyLength_v);
	DDX_Text(pDX, IDC_EDIT_MESSAGE, edit_message_v);
	DDX_Text(pDX, IDC_STATIC_MESSAGE, static_message_v);
	DDX_Text(pDX, IDC_EDIT_ENCODED_MESSAGE, edit_encodedMessage_v);
	DDX_Text(pDX, IDC_EDIT_MESSAGE_MEMO, edit_messageMemo_v);
	DDX_Text(pDX, IDC_EDIT_ENCODED_MESSAGE_MEMO, edit_encodedMessageMemo_v);
	DDV_MaxChars(pDX, edit_key_v, 8);
	DDX_Text(pDX, IDC_STATIC_ENCODED_MESSAGE, static_encodedMessage_v);
}

BEGIN_MESSAGE_MAP(Clr_2_sopadDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_EN_CHANGE(IDC_EDIT_KEY, &Clr_2_sopadDlg::OnEnChangeEditKey)
	ON_WM_CREATE()
	ON_EN_CHANGE(IDC_EDIT_MESSAGE, &Clr_2_sopadDlg::OnEnChangeEditMessage)
	ON_BN_CLICKED(IDC_MFCBUTTON_CLEAR, &Clr_2_sopadDlg::OnBnClickedMfcbuttonClear)
	ON_BN_CLICKED(IDEXIT, &Clr_2_sopadDlg::OnBnClickedExit)
	ON_BN_CLICKED(IDC_MFCBUTTON_ENCODE, &Clr_2_sopadDlg::OnBnClickedMfcbuttonEncode)
	ON_BN_CLICKED(IDC_MFCBUTTON_DECODE, &Clr_2_sopadDlg::OnBnClickedMfcbuttonDecode)
	ON_EN_CHANGE(IDC_EDIT_ENCODED_MESSAGE, &Clr_2_sopadDlg::OnEnChangeEditEncodedMessage)
END_MESSAGE_MAP()


// обработчики сообщений Clr_2_sopadDlg

BOOL Clr_2_sopadDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Добавление пункта "О программе..." в системное меню.

	// IDM_ABOUTBOX должен быть в пределах системной команды.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Задает значок для этого диалогового окна.  Среда делает это автоматически,
	//  если главное окно приложения не является диалоговым
	SetIcon(m_hIcon, TRUE);			// Крупный значок
	SetIcon(m_hIcon, FALSE);		// Мелкий значок

	// TODO: добавьте дополнительную инициализацию
	setlocale(LC_ALL, "Russian");

	return TRUE;  // возврат значения TRUE, если фокус не передан элементу управления
}

void Clr_2_sopadDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// При добавлении кнопки свертывания в диалоговое окно нужно воспользоваться приведенным ниже кодом,
//  чтобы нарисовать значок.  Для приложений MFC, использующих модель документов или представлений,
//  это автоматически выполняется рабочей областью.

void Clr_2_sopadDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // контекст устройства для рисования

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Выравнивание значка по центру клиентского прямоугольника
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Нарисуйте значок
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// Система вызывает эту функцию для получения отображения курсора при перемещении
//  свернутого окна.
HCURSOR Clr_2_sopadDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



// conversion from WCHAR(CString) to char*
char* _wtoa(CString _String) {
	int length = _String.GetLength();
	char *result = new char[length];
	int i = 0;

	for (; i < length; i++) {
		result[i] = _String[i];
	}
	result[i] = '\0';

	return result;
}


// conversion from char* to WCHAR(CString)
CString _atow(char *_String) {
	int length = strlen(_String);
	CString result = _T("");
	int i = 0;

	for (; i < length; i++) {
		result += _String[i];
	}

	return result;
}


char* copy(char *_Dest, char *_Source, int _Count, int _Index = 0) {
	int i = 0;
	for (int j = 0; (j < _Count) && (i < strlen(_Source)); i++, j++) {
		_Dest[j] = _Source[_Index + j];
	}
	_Dest[i] = '\0';

	return _Dest;
}


int Clr_2_sopadDlg::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CDialogEx::OnCreate(lpCreateStruct) == -1)
		return -1;

	edit_key_v = _T("password");
	edit_message_v = _T("password");
	edit_messageMemo_v = _T("70617373776f7264");

	static_keyLength_v = _T("8 characters");
	static_message_v = _T("Message - (8 characters)");
	static_encodedMessage_v = _T("Encoded Message - (0 characters)");

	return 0;
}


void Clr_2_sopadDlg::OnEnChangeEditKey()
{
	UpdateData(1);

	int length = edit_key_v.GetLength();
	
	if (length == 1) {
		static_keyLength_v = _T("1 character");
	}
	else {
		CString str;
		str.Format(_T("%d"), length);
		static_keyLength_v = str + _T(" characters");
	}

	UpdateData(0);
}


void Clr_2_sopadDlg::OnEnChangeEditMessage()
{
	UpdateData(1);

	int length = edit_message_v.GetLength();
	edit_messageMemo_v = _T("");

	if (length == 1) {
		static_message_v = _T("Message - (1 character)");
	}
	else {
		CString str;
		str.Format(_T("%d"), length);
		static_message_v = _T("Message - (") + str;
		static_message_v += _T(" characters)");
	}

	char *charToByte = _wtoa(edit_message_v);
	for (int i = 0; i < strlen(charToByte); i++) {
		int temp = (int)(charToByte[i]);
		CString str;
		str.Format(_T("%x"), temp);
		edit_messageMemo_v += str;
	}

	UpdateData(0);
}


void Clr_2_sopadDlg::OnEnChangeEditEncodedMessage()
{
	UpdateData(1);

	int length = edit_encodedMessage_v.GetLength();
	edit_encodedMessageMemo_v = _T("");

	if (length == 1) {
		static_encodedMessage_v = _T("Encoded Message - (1 character)");
	}
	else {
		CString str;
		str.Format(_T("%d"), length);
		static_encodedMessage_v = _T("Encoded Message - (") + str;
		static_encodedMessage_v += _T(" characters)");
	}

	char *charToByte = _wtoa(edit_encodedMessage_v);
	for (int i = 0; i < strlen(charToByte); i++) {
		int temp = (int)(charToByte[i]);
		CString str;
		str.Format(_T("%x"), temp);
		edit_encodedMessageMemo_v += str;
	}

	UpdateData(0);
}


void Clr_2_sopadDlg::OnBnClickedMfcbuttonClear()
{
	UpdateData(1);

	edit_key_v = _T("");
	edit_message_v = _T("");
	edit_encodedMessage_v = _T("");
	edit_messageMemo_v = _T("");
	edit_encodedMessageMemo_v = _T("");

	static_keyLength_v = _T("0 characters");
	static_message_v = _T("Message - (0 characters)");
	static_encodedMessage_v = _T("Encoded Message - (0 characters)");

	UpdateData(0);
}


void Clr_2_sopadDlg::OnBnClickedExit()
{
	exit(0);
}


DES des;
char *strTmp;


void Clr_2_sopadDlg::OnBnClickedMfcbuttonEncode()
{
	UpdateData(1);

	if ((edit_message_v.GetLength() % 8 != 0) || (edit_key_v.GetLength() != 8)) {
		MessageBox(_T("Quantity of characters must be a multiple to 8.\n\
Newline is counted as 2 characters.\n\
Key must have 8 characters."), _T("Warning!"), MB_OK);
		return;
	}
	
	char *source = _wtoa(edit_message_v);
	strTmp = des.Encrypt(source, _wtoa(edit_key_v));
	edit_encodedMessage_v = _atow(strTmp);

	char *charToByte = _wtoa(edit_encodedMessage_v);
	for (int i = 0; i < strlen(charToByte); i++) {
		int temp = (int)(charToByte[i]);
		CString str;
		str.Format(_T("%x"), temp);
		edit_encodedMessageMemo_v += str;
	}

	CString str;
	str.Format(_T("%d"), edit_encodedMessage_v.GetLength());
	static_encodedMessage_v = _T("Encoded Message - (") + str;
	static_encodedMessage_v += _T(" characters)");
	
	UpdateData(0);
}


void Clr_2_sopadDlg::OnBnClickedMfcbuttonDecode()
{
	UpdateData(1);

	if ((edit_encodedMessage_v.GetLength() % 8 != 0) || (edit_key_v.GetLength() != 8)) {
		MessageBox(_T("Quantity of characters must be a multiple to 8\n\
Newline is counted as 2 characters.\n\
Key must have 8 characters."), _T("Warning!"), MB_OK);
		return;
	}

	char *source = strTmp;
	strTmp = des.Decrypt(source, _wtoa(edit_key_v));
	edit_message_v = _atow(strTmp);

	char *charToByte = _wtoa(edit_message_v);
	for (int i = 0; i < strlen(charToByte); i++) {
		int temp = (int)(charToByte[i]);
		CString str;
		str.Format(_T("%x"), temp);
		edit_messageMemo_v += str;
	}

	CString str;
	str.Format(_T("%d"), edit_message_v.GetLength());
	static_message_v = _T("Decoded Message - (") + str;
	static_message_v += _T(" characters)");

	UpdateData(0);
}

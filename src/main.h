#include "control.h"
#include "stageselect.h"
#include "message.h"
#include "barselect.h"
#include "title.h"

class MAIN{
private:
	STAGESELECT *stageselect;
	CONTROL *control;
	MESSAGE *message;
	BARSELECT *barselect;
	TITLE *title;
	int m_actcount;
	int act;
	int stock;
	bool keycheck;
	bool automode;
	void ReStart();
	void ATMode();

	int c; // �I�[�g�҂���ԕϐ�

	bool dxlib;
public:
	bool All();

	MAIN();
	~MAIN();
	void KeyCheck();
};
#include "pch.h"
class BARSELECT{
private:

	// �I���t���O�B�I���Ȃ�true
	bool endflag;
	
	// �o�[�O���t�B�b�N�n���h��
	int bargh[3];

	// �o�[�Z���N�g�O���t�B�b�N�n���h��
	int bselectgh;

	// �I�����ƌ��艹�̃t���O
	bool selectflag, decisionflag;

	// �I�����ƌ��艹�̃T�E���h�n���h��
	int sh,dh;

	// �L�[���̗͂V��
	int keycount;

	// �I�[�g���̗͂V��
	int autocount;


private:
	void Draw();
	void KeyGet();
	
public:
	bool All();
	BARSELECT();
	
	~BARSELECT();
	void SetFlag(bool);
	bool GetFlag();
	void Reset();
	//void SetValue(int bar, int stage, int score, int stock);

	// �I���o�[���
	int mbar;
};
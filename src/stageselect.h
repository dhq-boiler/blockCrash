#include "pch.h"
class STAGESELECT{
private:

	// �I���t���O�B�I���Ȃ�true
	bool endflag;

	// �O���t�B�b�N�n���h��
	int bargh[3], ballgh;
	
	// �X�e�[�W�O���t�B�b�N�n���h��
	int stagegh[6];

	// �X�e�[�W�ڍ׃O���t�B�b�N�n���h��
	int sdetailgh[6];

	// �X�e�[�W�N���A�n���h�� 
	bool clear[6];

	// �X�e�[�W�Z���N�g�O���t�B�b�N�n���h��
	int sselectgh;

	// �N���A�\���O���t�B�b�N�n���h��
	int cleargh;

	// �I�����ƌ��艹�̃t���O
	bool selectflag, decisionflag;

	// �I�����ƌ��艹�̃T�E���h�n���h��
	int sh,dh;

	// �L�[���̗͂V��
	int keycount;

	// ������̗͂V�� //�Ȃ�����
	int entercount;

	// �I�[�g���̗͂V��
	int autocount;

private:
	void Draw();
	void KeyGet();
	//void SoundPlay();
public:
	bool All();
	STAGESELECT();
	~STAGESELECT();
	void SetFlag(bool);
	bool GetFlag();
	void Reset();
	void SetValue(int bar, int stage, int score, int stock);

	// ���_,�c�@
	int mscore,mstock;
	// �I���X�e�[�W��
	int mstage;

	// �I���o�[
	int mbar;
};
#include "pch.h"
class TITLE{
private:

	// �I���t���O�B�I���Ȃ�true
	bool endflag;
	
	// �^�C�g���O���t�B�b�N�n���h��
	int titlegh;

	// �I�����ƌ��艹�̃t���O
	bool selectflag, decisionflag;

	// �I�����ƌ��艹�̃T�E���h�n���h��
	int sh,dh;

private:
	void Draw();
	void KeyGet();
public:
	bool All();
	TITLE();
	~TITLE();
	void SetFlag(bool);
	bool GetFlag();

};
#include "pch.h"

class BLOCK{
private:
	//���W
	int x,y;

	//�c�A����
	int width,height,itemwidth,itemheight;

	//�u���b�N�����Ă邩���ĂȂ����̃t���O�B
	bool endflag;

	//�O���t�B�b�N�n���h���B
	static	int gh[8];

	// �A�C�e���̃O���t�B�b�N�n���h��
	static int itemgh[5];

	// �u���b�N�T�C�Y�𔼕��ɂ��邩�ǂ���
	bool half;

	//�t�F�[�h�`��p�J�E���g
	int count;

private:
	void Draw(int blockhandle);
public:
	int GetX();
	int GetY();
	int GetWidth();
	int GetHeight();
	void SetFlag(bool);
	bool GetFlag();
	void SetItemFlag(bool);
	bool GetItemFlag();
	void SetHalfFlag(bool flag);

	BLOCK(char *,int,int);
	void All(int blockhandle);

	
	// �A�C�e�����
	enum ItemType{
		ITEMTYPE_LONG,
		ITEMTYPE_POWERUP,
		ITEMTYPE_INCRESE,
		ITEMTYPE_1UP,
		ITEMTYPE_SCOREUP
	};


	// �A�C�e���������Ă��邩�ǂ����̃t���O
	bool itemflag;
	enum ItemType it;
};

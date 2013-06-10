#include "pch.h"
#include "bar.h"
#include "ball.h"
#include "block.h"

class CONTROL{
private:
	//�o�[�N���X�̃|�C���^
	BAR *bar;
	//�{�[���N���X�̃|�C���^
	BALL *ball;

	//�{�[���N���X�̃|�C���^�i���ʁj
	BALL *sball[MAX_SBALLCOUNT];
	
	//�u���b�N�N���X�̃|�C���^
	BLOCK *block[MAX_BLOCKCOUNT];

	//�{�[���ƃo�[�ƃu���b�N�̍��W
	int bdx,bdy,blx,bly,bkx,bky;

	
	//�{�[���ƃo�[�ƃu���b�N�̉摜�̕��ƍ���
	int bdwidth,bdheight,blwidth,blheight,bkwidth,bkheight;

	// �o�[���g�傷��T�C�Y (���̃o�[�̕��̔���)
	int exwidth;

	//�o�E���h���ƂԂ��艹�̃t���O
	bool boundflag,demolishflag;

	//�o�E���h���ƂԂ��艹�̃T�E���h�n���h��
	int bh,dh;

	// ���ʂ̐�
	int sballcount;

	// ���x��,���_,�c�@
	int mlevel,mscore,mstock;

	// �c�@�������O���t�B�b�N�n���h��
	int gh;

	// �\���J�E���g
	int act;

	// �u���b�N��
	int sumblock;

	// �X�e�[�W��
	int mstage;

	// �����x
	int accel;

	// �o�[�̎��
	int barnum;

	// ���x�㏸�J�E���g
	int ballspup;

	// ���x�ύX�J�E���g // �i�܂Ȃ��Ȃ����Ƃ��p
	int vspeed;

private:
	void HitCheckBallAndBar( BALL *ball);
	void HitCheckBallAndBlock( BALL *ball);
	void SoundPlay();
	void ItemEffect( enum BLOCK::ItemType it, int bx, int by);
public:
	bool All();
	void Reset();
	int GetStage();
	int GetScore();
	int GetStock();
	int GetBar();

	// �N���A�n���h��
	bool clear;
	CONTROL( int mbar, int stage, int score, int stock );
	~CONTROL();
};


	
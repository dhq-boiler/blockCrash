#include "pch.h"
#include "stageselect.h"

STAGESELECT::STAGESELECT()
{

	mstage = 1;
	keycount = 8;
	
	bargh[0] = LoadGraph(TEXT("bar.bmp")); // �o�[�P
	bargh[1] = LoadGraph(TEXT("barsecond.bmp")); // �o�[�Q
	bargh[2] = LoadGraph(TEXT("barthird.bmp")); // �o�[�R

	ballgh = LoadGraph(TEXT("ball_b.png")); // �c�@�\��

	stagegh[0] = LoadGraph(TEXT("stage1mini.png")); // �X�e�[�W�P
	stagegh[1] = LoadGraph(TEXT("stage2mini.png")); // �X�e�[�W�Q
	stagegh[2] = LoadGraph(TEXT("stage3mini.png")); // �X�e�[�W�R
	stagegh[3] = LoadGraph(TEXT("stage4mini.png")); // �X�e�[�W�S
	stagegh[4] = LoadGraph(TEXT("stage5mini.png")); // �X�e�[�W�T
	stagegh[5] = LoadGraph(TEXT("ball_a.png")); // �X�e�[�W�T

	sdetailgh[0] = LoadGraph(TEXT("stage1.png")); // �X�e�[�W�P�ڍ�
	sdetailgh[1] = LoadGraph(TEXT("stage2.png")); // �X�e�[�W�Q�ڍ�
	sdetailgh[2] = LoadGraph(TEXT("stage3.png")); // �X�e�[�W�R�ڍ�
	sdetailgh[3] = LoadGraph(TEXT("stage4.png")); // �X�e�[�W�S�ڍ�
	sdetailgh[4] = LoadGraph(TEXT("stage5.png")); // �X�e�[�W�T�ڍ�
	sdetailgh[5] = LoadGraph(TEXT("ball_a.png")); // �X�e�[�W�U�ڍ�

	sselectgh = LoadGraph(TEXT("stageselect.png")); // �X�e�[�W�Z���N�g�^�C�g��
	cleargh = LoadGraph(TEXT("clearstar.png")); // �N���A�\��

	selectflag = false;
	decisionflag = false;

	endflag = false;

	//�����t�@�C���ǂݍ��݁B
	sh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

	for(int i =0; i < 6; ++i){
		clear[i] = false;
	}
	mscore = 0;
	mstock = 2;
	mbar = 1;
	
	entercount = 0;
	// �I�[�g���̗͂V��
	autocount = 0;

}


STAGESELECT::~STAGESELECT()
{
}

void STAGESELECT::SetValue(int bar, int stage, int score, int stock){
	mbar = bar;
	clear[stage-1] = true;
	mscore = score;
	mstock = stock;
}

void STAGESELECT::Reset(){
	for(int i = 0; i < 5; ++i){
		clear[i] = false;
	}
	mscore = 0;
	mstock = 2;
}

void STAGESELECT::Draw(){

	DrawGraph(0, 0 ,sselectgh,TRUE); // �X�e�[�W�^�C�g���\��
	DrawGraph(400, 320 ,sdetailgh[mstage-1],TRUE); // �X�e�[�W�^�C�g���\��

	switch(mstage){ // �X�e�[�W�ڍו\��
	case 1: DrawString( 40, 340, TEXT("�I�i�W�~�T��"), RGB(255,120,0));
			break;
	case 2: DrawString( 40, 340, TEXT("�S�̓�"), RGB(255,120,0));
			break;
	case 3: DrawString( 40, 340, TEXT("�N���X�N���X"), RGB(255,120,0));
			break;
	case 4: DrawString( 40, 340, TEXT("�~�̗�"), RGB(255,120,0));
			break;
	case 5: DrawString( 40, 340, TEXT("����͎��B�ł��B"), RGB(255,120,0));
			break;
	// �ǉ��X�e�[�W�F���Ԃ�������ǉ����悤
	/*case 6: DrawString( 40, 340, TEXT("�v���C���肪�Ƃ��������܂��B"), RGB(255,120,0));
			break;*/
	}
	for (int i = 0; i < 5; ++i){
		DrawGraph(60+i*120, 200 ,stagegh[i],TRUE); // �X�e�[�W�^�C�g���\��
	}
	if(clear[mstage-1]){
			DrawGraph(700, 320 ,cleargh,TRUE); // �X�e�[�W�^�C�g���\��
	}

	DrawBox( 60+(mstage-1)*120, 200, 160+(mstage-1)*120, 270 , RGB(255,20,30), false); // �I��g�\��
	DrawBox( 400, 320, 750, 578 , RGB(255,20,30), false); // �ڍטg�\��
	
	DrawGraph(40, 460 , bargh[mbar-1], TRUE); // �I���o�[�\��

	DrawFormatString( 40, 500, RGB(255,120,0), TEXT("SCORE: %d"), mscore);
	DrawFormatString( 40, 540, RGB(255,120,0), TEXT("STOCK: %d"), mstock);
	
}

void STAGESELECT::KeyGet()
{
	if(rB){ // �E�{�^��
		if(AT){ // �I�[�g���[�h�̏ꍇ
			++autocount;
		}
		++mstage;
		if(mstage > 5){
			mstage = 1;
		}
		rB = false;
	}
	if(lB){ // ���{�^��
		if(AT){ // �I�[�g���[�h�̏ꍇ
			++autocount;
		}
		--mstage;
		if(mstage < 1){
			mstage = 5;
		}
		lB = false;
	}
	if(AT){ // �I�[�g���[�h�̏ꍇ
		if(eB && autocount > 10){ // ����{�^��
			endflag = true;
			eB = false;
			autocount =0;
		}
	}
	else if (eB){ // ����{�^��
		endflag = true;
		eB = false;
	}

}


bool STAGESELECT::All()
{
	//�L�[����
	KeyGet();

	//�`�揈��
	Draw();

	return endflag;
}

void STAGESELECT::SetFlag( bool flag){
	endflag = flag;
}
bool STAGESELECT::GetFlag(){
	return endflag;
}
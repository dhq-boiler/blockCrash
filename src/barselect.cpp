#include "pch.h"
#include "barselect.h"


BARSELECT::BARSELECT()
{

	mbar = 1;
	keycount = 8; // �L�[�{�[�h���͂̏ꍇ�ɕK�v

	bargh[0] = LoadGraph(TEXT("bar.bmp")); // �o�[�P
	bargh[1] = LoadGraph(TEXT("barsecond.bmp")); // �o�[�Q
	bargh[2] = LoadGraph(TEXT("barthird.bmp")); // �o�[�R

	bselectgh = LoadGraph(TEXT("barselect.png")); // �o�[�Z���N�g�^�C�g��

	selectflag = false;
	decisionflag = false;

	endflag = false;

	autocount = 0;

	//�����t�@�C���ǂݍ��݁B
	sh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

}


BARSELECT::~BARSELECT()
{
}

void BARSELECT::Reset(){
	mbar = 1;
}

void BARSELECT::Draw(){

	DrawGraph(30, 0 ,bselectgh,TRUE); // �o�[�^�C�g���\��

	switch(mbar){ // �o�[�ڍו\��
	case 1: DrawString( 440, 240, TEXT("BAR NAME�F"), RGB(255,180,0));
			DrawString( 560, 240, TEXT("�m�[�}���o�["), RGB(255,255,128));
			DrawString( 440, 300, TEXT("BALL SPEED�F"), RGB(255,180,0));
			DrawString( 570, 300, TEXT("��"), RGB(255,180,128));
			DrawString( 440, 360, TEXT("TECHNICAL�F"), RGB(255,180,0));
			DrawString( 570, 360, TEXT("��"), RGB(255,180,128));
			DrawString( 440, 420, TEXT("DIFFICULTY�F"), RGB(255,180,0));
			DrawString( 570, 420, TEXT("��"), RGB(255,180,128));
			break;
	case 2: DrawString( 440, 240, TEXT("BAR NAME�F"), RGB(255,180,0));
			DrawString( 560, 240, TEXT("�Q���@"), RGB(255,255,128));
			DrawString( 440, 300, TEXT("BALL SPEED�F"), RGB(255,180,0));
			DrawString( 570, 300, TEXT("���@���@��"), RGB(255,180,128));
			DrawString( 440, 360, TEXT("TECHNICAL�F"), RGB(255,180,0));
			DrawString( 570, 360, TEXT("���@��"), RGB(255,180,128));
			DrawString( 440, 420, TEXT("DIFFICULTY�F"), RGB(255,180,0));
			DrawString( 570, 420, TEXT("���@��"), RGB(255,180,128));
			break;
	case 3: DrawString( 440, 240, TEXT("BAR NAME�F"), RGB(255,180,0));
			DrawString( 560, 240, TEXT("�R��"), RGB(255,255,128));
			DrawString( 440, 300, TEXT("BALL SPEED�F"), RGB(255,180,0));
			DrawString( 570, 300, TEXT("���@���@���@���@��"), RGB(255,0,128));
			DrawString( 440, 360, TEXT("TECHNICAL�F"), RGB(255,180,0));
			DrawString( 570, 360, TEXT("���@���@��"), RGB(255,0,128));
			DrawString( 440, 420, TEXT("DIFFICULTY�F"), RGB(255,180,0));
			DrawString( 570, 420, TEXT("���@���@���@���@��"), RGB(255,0,128));
			break;
	}
	for (int i = 0; i < 3; ++i){
		if(i == 2)
			DrawGraph(125, 200+i*120 ,bargh[i],TRUE); // �~�j�o�[��ޕ\��
		else
			DrawGraph(100, 200+i*120 ,bargh[i],TRUE); // �o�[��ޕ\��
	}

	DrawBox( 80, 190+(mbar-1)*120, 220, 224+(mbar-1)*120, RGB(255,20,30), false); // �I��g�\��
	DrawBox( 400, 220, 750, 478 , RGB(255,20,30), false); // �ڍטg�\��
	
}

void BARSELECT::KeyGet()
{
	if(rB){ // �E�{�^��
		if(AT){ // �I�[�g���[�h�̏ꍇ
			++autocount;
		}
		++mbar;
		if(mbar > 3){
			mbar = 1;
		}
		rB = false;
	}
	if(lB){ // ���{�^��
		if(AT){ // �I�[�g���[�h�̏ꍇ
			++autocount;
		}
		--mbar;
		if(mbar < 1){
			mbar = 3;
		}
		lB = false;
	}
	if(AT){ // �I�[�g���[�h�̏ꍇ
		if(eB && autocount > 10){ // ����{�^��
			endflag = true;
			eB = false;
			autocount = 0;
		}
	}
	else if (eB){ // ����{�^��
		endflag = true;
		eB = false;
	}
}


bool BARSELECT::All()
{
	//�L�[����
	KeyGet();

	//�`�揈��
	Draw();

	return endflag;
}

void BARSELECT::SetFlag( bool flag){
	endflag = flag;
}
bool BARSELECT::GetFlag(){
	return endflag;
}
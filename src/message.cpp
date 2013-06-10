#include "pch.h"
#include "message.h"

MESSAGE::MESSAGE( int pattern, int count)
{
	ct = count;
	endflag = false;
	switch( pattern ){
	case 1: mes = "BALL FAILED!!";
			break;
	case 2: mes = "CLEAR!!";
			break;
	case 3: mes = "GAME OVER!!";
			break;
	}
}


MESSAGE::~MESSAGE()
{
}

void MESSAGE::Draw(){
	
	if(ct > 0){
		SetDrawBlendMode( DX_BLENDMODE_ALPHA, 128 );
		DrawBox( 0, 0, WIDTH, HEIGHT, RGB(30,30,30), true);
		// �`�悷�镶����̃T�C�Y��ݒ�
		SetFontSize( 32 );
		// ������̕`��
		SetDrawBlendMode( DX_BLENDMODE_NOBLEND, 0);
		DrawFormatString( 250, 300,RGB(255,255,255), mes);
		SetFontSize( 16 );
		--ct;
	}
	else
		endflag = true;
}

void MESSAGE::KeyGet()
{

	if(key[KEY_INPUT_A] == 1){
		// ���o�X�L�b�v�{�^��
		endflag = true;
	}
}


bool MESSAGE::All()
{
	//�L�[����
	KeyGet();

	//�`�揈��
	Draw();

	return endflag;
}
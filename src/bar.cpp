#include "pch.h"
#include "bar.h"

BAR::BAR( int barnum )
{
	gh[0] = LoadGraph(TEXT("bar.bmp")); // �o�[�P
	gh[1] = LoadGraph(TEXT("barsecond.bmp")); // �o�[�Q
	gh[2] = LoadGraph(TEXT("barthird.bmp")); // �o�[�R

	mbar = barnum-1;

	GetGraphSize(gh[mbar],&width,&height);

	//y���W�͌Œ�Ȃ̂ł����Őݒ�
	y=540;

	//�ŏ��͐^��
	x=WIDTH/2;

	// �g�嗦�̏�����
	ex = 2;

	//�I���t���O�͋U�ɂ��Ƃ�
	endflag=false;

	end = false;
}

void BAR::Draw(){

	DrawExtendGraph(x-width*ex/4,y-height/2,x+width*ex/4,y+height/2,gh[mbar],TRUE);
}

bool BAR::KeyGet()
{
	bool on = false;
	
	if(barx){ // �o�[�̈ړ�
		x = barx;
		on = true;
	}

	if(key[KEY_INPUT_LEFT] == 1){
		//���Ɉړ��B
		x-=SPEED;
		accel = -1;
		on = true;
	}
	if(key[KEY_INPUT_RIGHT] == 1){
		//�E�Ɉړ�
		x+=SPEED;
		accel = 1;
		on = true;
	}
	if(key[KEY_INPUT_ESCAPE] == 1){
		//�G�X�P�[�v�L�[��������Ă���ΏI���t���O��true�ɂ���
		endflag=true;
	}

	//��ʂ̂͂ݏo������
	if(x<width*ex/4)
		x=width*ex/4;

	if(x>WIDTH-width*ex/4)
		x=WIDTH-width*ex/4;
	mx = x;
	return on;
}

int BAR::GetAcceleration()
{
	return accel;
}

void BAR::SetX( int vx )
{
	x = vx;
}
int BAR::GetX()
{
	return x;
}

int BAR::GetY()
{
	return y;
}

int BAR::GetWidth()
{
	return width;

}

int BAR::GetHeight()
{
	return height;
}

void BAR::ExtendWidth()
{
	++ex;
}

void BAR::Reset(){ // ���Z�b�g
	ex = 2; 
}

void BAR::SetFlag( bool flag){
	end = flag;
}

bool BAR::All()
{
	
	if(!end){
		//�L�[����
		if(!KeyGet())
			accel = 0;
	}

	//�`�揈��
	Draw();

	//�I���t���O��Ԃ��B
	return endflag;

}


void BAR::Destroy(){

	
}


BAR::~BAR()
{
	Destroy();

}









	



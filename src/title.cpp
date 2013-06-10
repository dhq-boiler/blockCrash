#include "pch.h"
#include "title.h"


TITLE::TITLE()
{
	titlegh = LoadGraph(TEXT("title.png")); // �^�C�g��

	selectflag = false;
	decisionflag = false;

	endflag = false;

	//�����t�@�C���ǂݍ��݁B
	sh = LoadSoundMem(TEXT("bound.wav"));
	dh = LoadSoundMem(TEXT("demolish.wav"));

}


TITLE::~TITLE()
{
}

void TITLE::Draw(){

	DrawGraph(0, 0 ,titlegh,TRUE); // �^�C�g���\��
	
}

void TITLE::KeyGet()
{
	if(rB || lB || eB){ // �{�^��on
		endflag = true;
	}
}


bool TITLE::All()
{
	//�L�[����
	KeyGet();

	//�`�揈��
	Draw();

	return endflag;
}

void TITLE::SetFlag( bool flag){
	endflag = flag;
}
bool TITLE::GetFlag(){
	return endflag;
}
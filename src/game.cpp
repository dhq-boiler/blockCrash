
// �Q�[�����̓��͂ɕϊ����邽�߂̃N���X
#include "main.h"
#include "game.h"

bool RB,LB,EB,AT,Key,rB,lB,eB;
int barx; 

GAME::GAME()
{
	main = new MAIN;
}


GAME::~GAME()
{
	delete main;
}

bool GAME::GameStart(){
	if(main->All() == 0)
		return false;
	return true;
}	

void GAME::RButton(){ // ������
	RB = true;
	Key = true;
}
void GAME::LButton(){ // �E����
	LB = true;
	Key = true;
}
void GAME::BarMove( int vx ){ // �o�[��x���W�X�V
	barx = vx;
}
void GAME::EnterButton(){ // ����{�^��
	EB = true;
	Key = true;
}
void GAME::Auto( bool on){
	AT = on;
}
void GAME::KeyEnd(){
	Key = false;
}

// ゲーム内の入力に変換するためのクラス
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

void GAME::RButton(){ // 左入力
	RB = true;
	Key = true;
}
void GAME::LButton(){ // 右入力
	LB = true;
	Key = true;
}
void GAME::BarMove( int vx ){ // バーのx座標更新
	barx = vx;
}
void GAME::EnterButton(){ // 決定ボタン
	EB = true;
	Key = true;
}
void GAME::Auto( bool on){
	AT = on;
}
void GAME::KeyEnd(){
	Key = false;
}